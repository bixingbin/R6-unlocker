namespace SumTing_Special
{
    partial class UnlockerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnlockerForm));
            this.FormDragBarPnl = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiddlePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusDynamicLbl = new System.Windows.Forms.Label();
            this.StatusStaticLbl = new System.Windows.Forms.Label();
            this.AutoSpoofCKB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.FixWifiBtn = new System.Windows.Forms.Button();
            this.KeyBindTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.KeyBindLbl = new System.Windows.Forms.Label();
            this.AdapterLbl = new System.Windows.Forms.Label();
            this.AdaptersCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SpoofMacBtn = new System.Windows.Forms.Button();
            this.updateHotkeyTimer = new System.Windows.Forms.Timer(this.components);
            this.FormDragBarPnl.SuspendLayout();
            this.MiddlePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormDragBarPnl
            // 
            this.FormDragBarPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
            this.FormDragBarPnl.Controls.Add(this.ExitBtn);
            this.FormDragBarPnl.Location = new System.Drawing.Point(0, 0);
            this.FormDragBarPnl.Name = "FormDragBarPnl";
            this.FormDragBarPnl.Size = new System.Drawing.Size(192, 34);
            this.FormDragBarPnl.TabIndex = 1;
            this.FormDragBarPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseDown);
            this.FormDragBarPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseMove);
            this.FormDragBarPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDragBarPnl_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Image = global::SumTing_Special.Properties.Resources.icons8_minimize_20;
            this.MinimizeBtn.Location = new System.Drawing.Point(139, 7);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::SumTing_Special.Properties.Resources.icons8_x_20;
            this.ExitBtn.Location = new System.Drawing.Point(164, 7);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiddlePnl
            // 
            this.MiddlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MiddlePnl.Controls.Add(this.panel1);
            this.MiddlePnl.Location = new System.Drawing.Point(4, 40);
            this.MiddlePnl.Name = "MiddlePnl";
            this.MiddlePnl.Size = new System.Drawing.Size(182, 287);
            this.MiddlePnl.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.StatusDynamicLbl);
            this.panel1.Controls.Add(this.StatusStaticLbl);
            this.panel1.Controls.Add(this.AutoSpoofCKB);
            this.panel1.Controls.Add(this.FixWifiBtn);
            this.panel1.Controls.Add(this.KeyBindTB);
            this.panel1.Controls.Add(this.KeyBindLbl);
            this.panel1.Controls.Add(this.AdapterLbl);
            this.panel1.Controls.Add(this.AdaptersCB);
            this.panel1.Controls.Add(this.SpoofMacBtn);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 269);
            this.panel1.TabIndex = 4;
            // 
            // StatusDynamicLbl
            // 
            this.StatusDynamicLbl.AutoSize = true;
            this.StatusDynamicLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.StatusDynamicLbl.ForeColor = System.Drawing.Color.White;
            this.StatusDynamicLbl.Location = new System.Drawing.Point(61, 245);
            this.StatusDynamicLbl.Name = "StatusDynamicLbl";
            this.StatusDynamicLbl.Size = new System.Drawing.Size(29, 16);
            this.StatusDynamicLbl.TabIndex = 11;
            this.StatusDynamicLbl.Text = "null";
            this.StatusDynamicLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusStaticLbl
            // 
            this.StatusStaticLbl.AutoSize = true;
            this.StatusStaticLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.StatusStaticLbl.ForeColor = System.Drawing.Color.White;
            this.StatusStaticLbl.Location = new System.Drawing.Point(8, 245);
            this.StatusStaticLbl.Name = "StatusStaticLbl";
            this.StatusStaticLbl.Size = new System.Drawing.Size(57, 16);
            this.StatusStaticLbl.TabIndex = 10;
            this.StatusStaticLbl.Text = "Status:";
            // 
            // AutoSpoofCKB
            // 
            this.AutoSpoofCKB.AutoSize = true;
            this.AutoSpoofCKB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AutoSpoofCKB.CheckedState.BorderRadius = 0;
            this.AutoSpoofCKB.CheckedState.BorderThickness = 0;
            this.AutoSpoofCKB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AutoSpoofCKB.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.AutoSpoofCKB.ForeColor = System.Drawing.Color.White;
            this.AutoSpoofCKB.Location = new System.Drawing.Point(32, 153);
            this.AutoSpoofCKB.Name = "AutoSpoofCKB";
            this.AutoSpoofCKB.Size = new System.Drawing.Size(100, 20);
            this.AutoSpoofCKB.TabIndex = 9;
            this.AutoSpoofCKB.Text = "Auto Spoof";
            this.AutoSpoofCKB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AutoSpoofCKB.UncheckedState.BorderRadius = 0;
            this.AutoSpoofCKB.UncheckedState.BorderThickness = 1;
            this.AutoSpoofCKB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AutoSpoofCKB.CheckedChanged += new System.EventHandler(this.AutoSpoofCKB_CheckedChanged);
            // 
            // FixWifiBtn
            // 
            this.FixWifiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FixWifiBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.FixWifiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FixWifiBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixWifiBtn.ForeColor = System.Drawing.Color.White;
            this.FixWifiBtn.Location = new System.Drawing.Point(6, 207);
            this.FixWifiBtn.Name = "FixWifiBtn";
            this.FixWifiBtn.Size = new System.Drawing.Size(152, 25);
            this.FixWifiBtn.TabIndex = 8;
            this.FixWifiBtn.Text = "Fix Wifi";
            this.FixWifiBtn.UseVisualStyleBackColor = false;
            this.FixWifiBtn.Click += new System.EventHandler(this.FixWifiBtn_Click);
            // 
            // KeyBindTB
            // 
            this.KeyBindTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.KeyBindTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyBindTB.DefaultText = "";
            this.KeyBindTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyBindTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyBindTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyBindTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyBindTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyBindTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyBindTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeyBindTB.ForeColor = System.Drawing.Color.White;
            this.KeyBindTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyBindTB.Location = new System.Drawing.Point(79, 73);
            this.KeyBindTB.Name = "KeyBindTB";
            this.KeyBindTB.PasswordChar = '\0';
            this.KeyBindTB.PlaceholderText = "";
            this.KeyBindTB.SelectedText = "";
            this.KeyBindTB.Size = new System.Drawing.Size(73, 22);
            this.KeyBindTB.TabIndex = 7;
            this.KeyBindTB.Click += new System.EventHandler(this.KeyBindTB_Click);
            this.KeyBindTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBindTB_KeyDown);
            this.KeyBindTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyBindTB_KeyPress);
            // 
            // KeyBindLbl
            // 
            this.KeyBindLbl.AutoSize = true;
            this.KeyBindLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.KeyBindLbl.ForeColor = System.Drawing.Color.White;
            this.KeyBindLbl.Location = new System.Drawing.Point(9, 76);
            this.KeyBindLbl.Name = "KeyBindLbl";
            this.KeyBindLbl.Size = new System.Drawing.Size(64, 16);
            this.KeyBindLbl.TabIndex = 6;
            this.KeyBindLbl.Text = "KeyBind:";
            // 
            // AdapterLbl
            // 
            this.AdapterLbl.AutoSize = true;
            this.AdapterLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.AdapterLbl.ForeColor = System.Drawing.Color.White;
            this.AdapterLbl.Location = new System.Drawing.Point(9, 7);
            this.AdapterLbl.Name = "AdapterLbl";
            this.AdapterLbl.Size = new System.Drawing.Size(65, 16);
            this.AdapterLbl.TabIndex = 5;
            this.AdapterLbl.Text = "Adapter:";
            // 
            // AdaptersCB
            // 
            this.AdaptersCB.BackColor = System.Drawing.Color.Transparent;
            this.AdaptersCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AdaptersCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AdaptersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdaptersCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AdaptersCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdaptersCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AdaptersCB.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AdaptersCB.ForeColor = System.Drawing.Color.White;
            this.AdaptersCB.ItemHeight = 18;
            this.AdaptersCB.Location = new System.Drawing.Point(12, 26);
            this.AdaptersCB.Name = "AdaptersCB";
            this.AdaptersCB.Size = new System.Drawing.Size(140, 24);
            this.AdaptersCB.TabIndex = 0;
            this.AdaptersCB.SelectedIndexChanged += new System.EventHandler(this.AdaptersCB_SelectedIndexChanged);
            // 
            // SpoofMacBtn
            // 
            this.SpoofMacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SpoofMacBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SpoofMacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpoofMacBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpoofMacBtn.ForeColor = System.Drawing.Color.White;
            this.SpoofMacBtn.Location = new System.Drawing.Point(6, 176);
            this.SpoofMacBtn.Name = "SpoofMacBtn";
            this.SpoofMacBtn.Size = new System.Drawing.Size(152, 25);
            this.SpoofMacBtn.TabIndex = 4;
            this.SpoofMacBtn.Text = "Spoof";
            this.SpoofMacBtn.UseVisualStyleBackColor = false;
            this.SpoofMacBtn.Click += new System.EventHandler(this.SpoofMacBtn_Click);
            // 
            // updateHotkeyTimer
            // 
            this.updateHotkeyTimer.Tick += new System.EventHandler(this.updateHotkeyTimer_Tick);
            // 
            // UnlockerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(191, 331);
            this.Controls.Add(this.MiddlePnl);
            this.Controls.Add(this.FormDragBarPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnlockerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnlockerForm_FormClosing);
            this.Load += new System.EventHandler(this.UnlockerForm_Load);
            this.FormDragBarPnl.ResumeLayout(false);
            this.MiddlePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormDragBarPnl;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel MiddlePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SpoofMacBtn;
        private Guna.UI2.WinForms.Guna2ComboBox AdaptersCB;
        private Guna.UI2.WinForms.Guna2TextBox KeyBindTB;
        private System.Windows.Forms.Label KeyBindLbl;
        private System.Windows.Forms.Label AdapterLbl;
        private System.Windows.Forms.Button FixWifiBtn;
        private Guna.UI2.WinForms.Guna2CheckBox AutoSpoofCKB;
        private System.Windows.Forms.Label StatusStaticLbl;
        private System.Windows.Forms.Timer updateHotkeyTimer;
        private System.Windows.Forms.Label StatusDynamicLbl;
    }
}