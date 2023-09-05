using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using YamlDotNet.Core;

namespace SumTing_Special
{
    public partial class UnlockerForm : Form
    {

        //
        //__/\\\\____________/\\\\________________________/\\\____________________________/\\\\\\\\\\\\\_________________        
        // _\/\\\\\\________/\\\\\\_______________________\/\\\___________________________\/\\\/////////\\\_______________       
        //  _\/\\\//\\\____/\\\//\\\_______________________\/\\\___________________________\/\\\_______\/\\\____/\\\__/\\\_      
        //   _\/\\\\///\\\/\\\/_\/\\\__/\\\\\\\\\___________\/\\\______/\\\\\\\\____________\/\\\\\\\\\\\\\\____\//\\\/\\\__     
        //    _\/\\\__\///\\\/___\/\\\_\////////\\\_____/\\\\\\\\\____/\\\/////\\\___________\/\\\/////////\\\____\//\\\\\___    
        //     _\/\\\____\///_____\/\\\___/\\\\\\\\\\___/\\\////\\\___/\\\\\\\\\\\____________\/\\\_______\/\\\_____\//\\\____   
        //      _\/\\\_____________\/\\\__/\\\/////\\\__\/\\\__\/\\\__\//\\///////_____________\/\\\_______\/\\\__/\\_/\\\_____  
        //       _\/\\\_____________\/\\\_\//\\\\\\\\/\\_\//\\\\\\\/\\__\//\\\\\\\\\\___________\/\\\\\\\\\\\\\/__\//\\\\/______ 
        //        _\///______________\///___\////////\//___\///////\//____\//////////____________\/////////////_____\////________
        //________________/\\\\\\\\\\\\\___________________________________________________________                              
        // _______________\/\\\/////////\\\_________________________________________________________                             
        //  _______________\/\\\_______\/\\\_______________________________/\\\\\\\\\____/\\\\\\\\\__                            
        //   __/\\\____/\\\_\/\\\\\\\\\\\\\/___/\\\____/\\\__/\\/\\\\\\\___/\\\/////\\\__/\\\/////\\\_                           
        //    _\//\\\__/\\\__\/\\\/////////____\/\\\___\/\\\_\/\\\/////\\\_\/\\\\\\\\\\__\/\\\\\\\\\\__                          
        //     __\//\\\/\\\___\/\\\_____________\/\\\___\/\\\_\/\\\___\///__\/\\\//////___\/\\\//////___                         
        //      ___\//\\\\\____\/\\\_____________\/\\\___\/\\\_\/\\\_________\/\\\_________\/\\\_________                        
        //       ____\//\\\_____\/\\\_____________\//\\\\\\\\\__\/\\\_________\/\\\_________\/\\\_________                       
        //        _____\///______\///_______________\/////////___\///__________\///__________\///__________                      
        //

        //enjoy the paste | Dont ask me for support for shit. if you don't understand it leave it the fuck alone



        private bool _UserDraggingForm = false;
        private Point _MouseOffset;
        private Keys _SelectedKey = Keys.None;
        private bool _CapturingKey = false;
        private Form _Form;
        private string _NewMac;
        private string _OldMac;
        private const int WMHotkey = 0x0312;
        private const int ModNoRepeat = 0x4000;
        private const int HotkeyID = 1;
        private string _KeyBind;
        private bool cooldownActive = false;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("gdi32.dll")]
        public static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);




        public UnlockerForm()
        {
            InitializeComponent();
            _Form = this;

            timer.Interval = 100; 
            timer.Tick += Timer_Tick;
            AdaptersCB.SelectedIndexChanged += AdaptersCB_SelectedIndexChanged;
            KeyBindTB.KeyDown += KeyBindTB_KeyDown;
            KeyBindTB.TextChanged += KeyBindTB_TextChanged;
            AutoSpoofCKB.CheckedChanged += AutoSpoofCKB_CheckedChanged;
        }

        private void UnlockerForm_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface Adapter in NetworkInterface.GetAllNetworkInterfaces().Where(FA => NetworkAdapter.IsValidMAC(FA.GetPhysicalAddress().GetAddressBytes(), true)).OrderByDescending(FA => FA.IsReceiveOnly))
            {
                AdaptersCB.Items.Add(new NetworkAdapter(Adapter));
            }
            UpdateStatusLabel();
        }



        private void FormDragBarPnl_MouseDown(object sender, MouseEventArgs e)
        {
            _MouseOffset = new Point(-e.X, -e.Y);
            _UserDraggingForm = true;
        }

        private void FormDragBarPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_UserDraggingForm)
            {
                Point _MousePos = Control.MousePosition;
                _MousePos.Offset(_MouseOffset.X, _MouseOffset.Y);

                this.Location = _MousePos;
            }
        }

        private void FormDragBarPnl_MouseUp(object sender, MouseEventArgs e)
        {
            _UserDraggingForm = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState |= FormWindowState.Normal;
            }
        }

        private void KeyBindTB_Click(object sender, EventArgs e)
        {
            KeyBindTB.Text = "Press any key...";
            _CapturingKey = true;
        }

        private void KeyBindTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (_CapturingKey && !_SelectedKey.HasFlag(Keys.Modifiers))
            {
                if (IsValidSingleCharacterKey(e.KeyCode))
                {
                    _SelectedKey = e.KeyCode;
                    KeyBindTB.Text = _SelectedKey.ToString();
                }
                else
                {
                    _SelectedKey = Keys.None;
                    KeyBindTB.Text = "Invalid key. Press any key...";
                }

                e.SuppressKeyPress = true;
                e.Handled = true;

                _Form.Focus();
                this.ActiveControl = null;

                UpdateStatusLabel();
            }

            if (string.IsNullOrEmpty(KeyBindTB.Text)) return;

            UnregisterHotKey(this.Handle, HotkeyID);

            uint modifiers = Convert.ToUInt32(ModifierKeys);
            uint key = Convert.ToUInt32(e.KeyCode);
            RegisterHotKey(this.Handle, HotkeyID, modifiers, key);

            _KeyBind = KeyBindTB.Text;

        }
        private void KeyBindTB_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel();
        }


        private void KeyBindTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_CapturingKey)
            {
                e.Handled = true;
            }
        }
        private bool IsValidSingleCharacterKey(Keys key)
        {
            return !key.HasFlag(Keys.Modifiers) && char.IsLetterOrDigit((char)key);
        }

        private void SpoofMacBtn_Click(object sender, EventArgs e)
        {
            _NewMac = NetworkAdapter.GenerateRandomMAC();


            if (NetworkAdapter.IsValidMAC(_NewMac, false))
            {
                SetMAC(_NewMac, "Change MAC Address");
            }
            else
            {
                
            }
        }


        public void SetMAC(string MAC, string Title)
        {
            NetworkAdapter Adapter = AdaptersCB.SelectedItem as NetworkAdapter;

            if (Adapter.SetRegistryPhysicalAddress(MAC, Title))
            {
                Thread.Sleep(333);
                UA();
            }
        }

        public void UA()
        {
            NetworkAdapter MAC = AdaptersCB.SelectedItem as NetworkAdapter;
            _OldMac = MAC.PhysicalAddress;
            if (!string.IsNullOrEmpty(MAC.RegistryPhysicalAddress))
            {
                _NewMac = MAC.RegistryPhysicalAddress;
            }
            else
            {
                _NewMac = _OldMac;
            }



        }

        private void AdaptersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UA();
            UpdateStatusLabel();
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WMHotkey && m.WParam.ToInt32() == HotkeyID)
            {

                _NewMac = NetworkAdapter.GenerateRandomMAC();


                if (NetworkAdapter.IsValidMAC(_NewMac, false))
                {
                    SetMAC(_NewMac, "Change MAC Address");
                }
                else
                {
                   
                }
            }

            base.WndProc(ref m);
        }

        private void updateHotkeyTimer_Tick(object sender, EventArgs e)
        {
            if (KeyBindTB.Text != _KeyBind)
            {
                UnregisterHotKey(this.Handle, HotkeyID);

                uint modifiers = Convert.ToUInt32(ModifierKeys);
                uint key = Convert.ToUInt32((Keys)Enum.Parse(typeof(Keys), KeyBindTB.Text));
                RegisterHotKey(this.Handle, HotkeyID, modifiers, key);

                _KeyBind = KeyBindTB.Text;
            }
        }

        private void FixWifiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID='Wi-Fi' OR NetConnectionID='Ethernet'";


                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                foreach (ManagementObject obj in searcher.Get())
                {

                    obj.InvokeMethod("Enable", null);
                }





            }
            catch (Exception)
            {

            }
        }
        
        private void AutoSpoofCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoSpoofCKB.Checked)
            {
                StartScanning();
                StatusDynamicLbl.Text = "Waiting";
            }
            else
            {
                StopScanning();
                UpdateStatusLabel();
            }

        }


        private void UnlockerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void StartScanning()
        {
            isScanning = true;
            timer.Start();
        }

        private void StopScanning()
        {
            isScanning = false;
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isScanning)
            {
                CheckPixelColors();
            }
        }

        private void CheckPixelColors()
        {
           
            Color targetColor1 = Color.FromArgb(22, 50, 72);
            Color targetColor2 = Color.FromArgb(255, 255, 255);
            Color targetColor3 = Color.FromArgb(21, 79, 126);

            
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

        
            Point location1 = new Point(screenBounds.Width / 4, screenBounds.Height / 4);
            Point location2 = new Point(screenBounds.Width / 2, screenBounds.Height / 2);
            Point location3 = new Point(3 * screenBounds.Width / 4, 3 * screenBounds.Height / 4);

       
            Color pixelColor1 = GetScreenPixelColor(location1);
            Color pixelColor2 = GetScreenPixelColor(location2);
            Color pixelColor3 = GetScreenPixelColor(location3);

     
            bool matchColor1 = AreColorsSimilar(pixelColor1, targetColor1, tolerance);
            bool matchColor2 = AreColorsSimilar(pixelColor2, targetColor2, tolerance);
            bool matchColor3 = AreColorsSimilar(pixelColor3, targetColor3, tolerance);

           
            if (matchColor1 && matchColor2 && matchColor3 && !cooldownActive)
            {
                MessageBox.Show("Match");

                
                StartCooldown(300000);
            }
        }
        private async void StartCooldown(int cooldownTime)
        {
            cooldownActive = true;
            UpdateStatusLabel();
            await Task.Delay(cooldownTime);
            cooldownActive = false;
            UpdateStatusLabel();
        }
        private bool AreColorsSimilar(Color color1, Color color2, int tolerance)
        {
            int diffR = Math.Abs(color1.R - color2.R);
            int diffG = Math.Abs(color1.G - color2.G);
            int diffB = Math.Abs(color1.B - color2.B);

            return diffR <= tolerance && diffG <= tolerance && diffB <= tolerance;
        }

        private Color GetScreenPixelColor(Point location)
        {
            using (Bitmap screenBmp = new Bitmap(1, 1))
            {
                using (Graphics g = Graphics.FromImage(screenBmp))
                {
                    g.CopyFromScreen(location, Point.Empty, new Size(1, 1));
                }

                return screenBmp.GetPixel(0, 0);
            }
        }

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool isScanning = false;
        private int tolerance = 0;



        private void UpdateStatusLabel()
        {
            if (cooldownActive)
            {
                StatusDynamicLbl.Text = "Cooldown";
                StatusDynamicLbl.ForeColor = Color.Blue;
            }
            if (AdaptersCB.SelectedItem == null)
            {
                StatusDynamicLbl.Text = "Select Adapter";
                StatusDynamicLbl.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(KeyBindTB.Text))
            {
                StatusDynamicLbl.Text = "Select Keybind";
                StatusDynamicLbl.ForeColor = Color.Red;
            }
            else
            {
                StatusDynamicLbl.Text = "Waiting";
                StatusDynamicLbl.ForeColor = Color.White;
            }
        }

    }
}

