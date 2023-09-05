using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.RepresentationModel;

namespace SumTing_Special
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


    public partial class SaveMounterForm : Form
    {

        private bool _UserDraggingForm = false;
        private Point _MouseOffset;
        private string savegamesPath;

        public SaveMounterForm()
        {
            InitializeComponent();

            ToolTip _ToolTipR6 = new ToolTip();
            _ToolTipR6.SetToolTip(R6PathTB, R6PathTB.Text);

            ToolTip _ToolTipUbi = new ToolTip();
            _ToolTipUbi.SetToolTip(UbiPathTB, UbiPathTB.Text);
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

        private void LocateUbiBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog _UbiFileDialog = new OpenFileDialog();
            _UbiFileDialog.Title = "Locate UbisoftConnect.exe";
            _UbiFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            _UbiFileDialog.FileName = "UbisoftConnect.exe";

            if (_UbiFileDialog.ShowDialog() == DialogResult.OK)
            {
                string _UbiPath = _UbiFileDialog.FileName;
                UbiPathTB.Text = _UbiPath;

                string directoryPath = Path.GetDirectoryName(_UbiPath);
                savegamesPath = Path.Combine(directoryPath, "savegames");

                if (Directory.Exists(savegamesPath))
                {
                    string[] userDirectories = Directory.GetDirectories(savegamesPath);


                    UserIDCB.Items.Clear();
                    foreach (string userDir in userDirectories)
                    {
                        string folderName = Path.GetFileName(userDir);
                        UserIDCB.Items.Add(folderName);
                    }
                }
                else
                {

                }

                UbiPathTB.Text = _UbiPath;
                StatusDynamicLbl.Text = "UbisoftConnect.exe located";
            }
        }

        private void LocateR6Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog _R6FileDialog = new OpenFileDialog();
            _R6FileDialog.Title = "Locate RainbowSix.exe";
            _R6FileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            _R6FileDialog.FileName = "RainbowSix.exe";

            if (_R6FileDialog.ShowDialog() == DialogResult.OK)
            {
                string _R6Path = _R6FileDialog.FileName;
                R6PathTB.Text = _R6Path;
                StatusDynamicLbl.Text = "RainbowSix.exe located";
            }
        }

        private void R6PathTB_TextChanged(object sender, EventArgs e)
        {
            ToolTip _ToolTipR6 = new ToolTip();
            _ToolTipR6.SetToolTip(R6PathTB, R6PathTB.Text);


        }

        private void UbiPathTB_TextChanged(object sender, EventArgs e)
        {
            ToolTip _ToolTipUbi = new ToolTip();
            _ToolTipUbi.SetToolTip(UbiPathTB, UbiPathTB.Text);
        }

        private void LoadSaveBtn_Click(object sender, EventArgs e)
        {
            string selectedFolder = UserIDCB.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFolder))
            {
                MessageBox.Show("Please select a folder from the UserIDCB ComboBox.");
                return;
            }

            string folder635Path = Path.Combine(savegamesPath, selectedFolder, "635");

            string folder1843Path = Path.Combine(savegamesPath, selectedFolder, "1843");

            bool folder635Exists = Directory.Exists(folder635Path);
            bool folder1843Exists = Directory.Exists(folder1843Path);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select 1.save file";
            openFileDialog.Filter = "1.save files|1.save|All files|*.*";
            openFileDialog.FileName = "1.save";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    if (!folder635Exists)
                        Directory.CreateDirectory(folder635Path);
                    if (!folder1843Exists)
                        Directory.CreateDirectory(folder1843Path);

                    File.Copy(selectedFilePath, Path.Combine(folder635Path, "1.save"), true);
                    File.Copy(selectedFilePath, Path.Combine(folder1843Path, "1.save"), true);

                    StatusDynamicLbl.Text = "1.save loaded ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading the 1.save file: " + ex.Message);
                }
            }
        }

        private void SaveMounterForm_Load(object sender, EventArgs e)
        {
            

        }

        private void AutoLoadSaveBtn_Click(object sender, EventArgs e)
        {
            string selectedFolder = UserIDCB.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedFolder))
            {
                MessageBox.Show("Please select a folder from the User ID Combo Box.");
                return;
            }

            string folder635Path = Path.Combine(savegamesPath, selectedFolder, "635");

            string folder1843Path = Path.Combine(savegamesPath, selectedFolder, "1843");

            bool folder635Exists = Directory.Exists(folder635Path);
            bool folder1843Exists = Directory.Exists(folder1843Path);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select 1.save file";
            openFileDialog.Filter = "1.save files|1.save|All files|*.*";
            openFileDialog.FileName = "1.save";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    if (!folder635Exists)
                        Directory.CreateDirectory(folder635Path);
                    if (!folder1843Exists)
                        Directory.CreateDirectory(folder1843Path);

                    File.Copy(selectedFilePath, Path.Combine(folder635Path, "1.save"), true);
                    File.Copy(selectedFilePath, Path.Combine(folder1843Path, "1.save"), true);

                    StatusDynamicLbl.Text = "1.save file loaded";

                    string settingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                                        "Ubisoft Game Launcher", "settings.yaml");
                    ModifySettingsYAML(settingsPath, true);

                    System.Diagnostics.Process.Start(R6PathTB.Text);
                    StatusDynamicLbl.Text = ("RainbowSix.exe Launching");
                    Thread.Sleep(120000);

                    CloseRainbowSix();

                    ModifySettingsYAML(settingsPath, false);

                    StatusDynamicLbl.Text = "RainbowSix.exe closed";
                    Thread.Sleep(500);
                    StatusDynamicLbl.Text = "Waiting";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while loading the 1.save file or modifying settings.yaml: " + ex.Message);
                }
            }
        }

        private void ModifySettingsYAML(string filePath, bool setOfflineTrue)
        {
            var yaml = new YamlStream();
            using (var reader = new StreamReader(filePath))
            {
                yaml.Load(reader);
            }

            var rootNode = (YamlMappingNode)yaml.Documents[0].RootNode;
            if (rootNode.Children.TryGetValue(new YamlScalarNode("games"), out var gamesNode)
                && gamesNode is YamlMappingNode gamesMappingNode
                && gamesMappingNode.Children.TryGetValue(new YamlScalarNode("TheDivision2"), out var division2Node)
                && division2Node is YamlMappingNode division2MappingNode
                && division2MappingNode.Children.TryGetValue(new YamlScalarNode("offline"), out var offlineNode))
            {
                if (setOfflineTrue)
                {
                    offlineNode = new YamlScalarNode("true");
                }
                else
                {
                    offlineNode = new YamlScalarNode("false");
                }

                division2MappingNode.Children[new YamlScalarNode("offline")] = offlineNode;

                using (var writer = new StreamWriter(filePath))
                {
                    yaml.Save(writer, false);
                }
            }
        }

        private void CloseRainbowSix()
        {
            string processName = "RainbowSix.exe";
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                try
                {
                    if (!process.HasExited)
                    {
                        process.CloseMainWindow();

                        if (!process.WaitForExit(3000)) 
                        {
                            process.Kill();
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void SaveMounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
