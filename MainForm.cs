using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.IO;
using System.Diagnostics;

namespace SumTing_Special
{
    public partial class MainForm : Form
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
        private UnlockerForm _UnlockerForm;
        private SaveMounterForm _SaveMounterForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void DiscordBtn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c start https://discord.com/invite/r4c");
        }

        private void WebsiteBtn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c start https://r4c.store");
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by vPurpp \n Version: 6.0", "About | Discord.gg/r4c", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UnlockerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnlockerForm _UnlockerForm = new UnlockerForm();
            _UnlockerForm.FormClosed += UnlockerForm_FormClosed;
            _UnlockerForm.Show();
            
        }


        private void UnlockerForm_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SaveMounterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SaveMounterForm _SaveMounterForm = new SaveMounterForm();
            _SaveMounterForm.FormClosed += SaveMounterForm_FormClosed;
            _SaveMounterForm.Show();
        }
        private void SaveMounterForm_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }


    }
}
