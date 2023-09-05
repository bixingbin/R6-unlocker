namespace SumTing_Special
{
    partial class SaveMounterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveMounterForm));
            this.FormDragBarPnl = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusDynamicLbl = new System.Windows.Forms.Label();
            this.StatusStaticLbl = new System.Windows.Forms.Label();
            this.UbiLocateLbl = new System.Windows.Forms.Label();
            this.R6LocateLbl = new System.Windows.Forms.Label();
            this.LocateUbiBtn = new System.Windows.Forms.Button();
            this.UbiPathTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.LocateR6Btn = new System.Windows.Forms.Button();
            this.R6PathTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.AutoLoadSaveBtn = new System.Windows.Forms.Button();
            this.LoadSaveBtn = new System.Windows.Forms.Button();
            this.UserIDLbl = new System.Windows.Forms.Label();
            this.UserIDCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MiddlePnl = new System.Windows.Forms.Panel();
            this.FormDragBarPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MiddlePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormDragBarPnl
            // 
            this.FormDragBarPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
            this.FormDragBarPnl.Controls.Add(this.ExitBtn);
            this.FormDragBarPnl.Location = new System.Drawing.Point(0, 0);
            this.FormDragBarPnl.Name = "FormDragBarPnl";
            this.FormDragBarPnl.Size = new System.Drawing.Size(191, 34);
            this.FormDragBarPnl.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.StatusDynamicLbl);
            this.panel1.Controls.Add(this.StatusStaticLbl);
            this.panel1.Controls.Add(this.UbiLocateLbl);
            this.panel1.Controls.Add(this.R6LocateLbl);
            this.panel1.Controls.Add(this.LocateUbiBtn);
            this.panel1.Controls.Add(this.UbiPathTB);
            this.panel1.Controls.Add(this.LocateR6Btn);
            this.panel1.Controls.Add(this.R6PathTB);
            this.panel1.Controls.Add(this.AutoLoadSaveBtn);
            this.panel1.Controls.Add(this.LoadSaveBtn);
            this.panel1.Controls.Add(this.UserIDLbl);
            this.panel1.Controls.Add(this.UserIDCB);
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
            this.StatusDynamicLbl.Location = new System.Drawing.Point(56, 240);
            this.StatusDynamicLbl.Name = "StatusDynamicLbl";
            this.StatusDynamicLbl.Size = new System.Drawing.Size(55, 16);
            this.StatusDynamicLbl.TabIndex = 17;
            this.StatusDynamicLbl.Text = "Waiting";
            this.StatusDynamicLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusStaticLbl
            // 
            this.StatusStaticLbl.AutoSize = true;
            this.StatusStaticLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.StatusStaticLbl.ForeColor = System.Drawing.Color.White;
            this.StatusStaticLbl.Location = new System.Drawing.Point(3, 240);
            this.StatusStaticLbl.Name = "StatusStaticLbl";
            this.StatusStaticLbl.Size = new System.Drawing.Size(57, 16);
            this.StatusStaticLbl.TabIndex = 16;
            this.StatusStaticLbl.Text = "Status:";
            // 
            // UbiLocateLbl
            // 
            this.UbiLocateLbl.AutoSize = true;
            this.UbiLocateLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.UbiLocateLbl.ForeColor = System.Drawing.Color.White;
            this.UbiLocateLbl.Location = new System.Drawing.Point(9, 85);
            this.UbiLocateLbl.Name = "UbiLocateLbl";
            this.UbiLocateLbl.Size = new System.Drawing.Size(68, 16);
            this.UbiLocateLbl.TabIndex = 15;
            this.UbiLocateLbl.Text = "Ubi Path:";
            // 
            // R6LocateLbl
            // 
            this.R6LocateLbl.AutoSize = true;
            this.R6LocateLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.R6LocateLbl.ForeColor = System.Drawing.Color.White;
            this.R6LocateLbl.Location = new System.Drawing.Point(9, 44);
            this.R6LocateLbl.Name = "R6LocateLbl";
            this.R6LocateLbl.Size = new System.Drawing.Size(64, 16);
            this.R6LocateLbl.TabIndex = 14;
            this.R6LocateLbl.Text = "R6 Path:";
            // 
            // LocateUbiBtn
            // 
            this.LocateUbiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocateUbiBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LocateUbiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocateUbiBtn.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.LocateUbiBtn.ForeColor = System.Drawing.Color.White;
            this.LocateUbiBtn.Location = new System.Drawing.Point(120, 101);
            this.LocateUbiBtn.Name = "LocateUbiBtn";
            this.LocateUbiBtn.Size = new System.Drawing.Size(32, 22);
            this.LocateUbiBtn.TabIndex = 13;
            this.LocateUbiBtn.Text = "...";
            this.LocateUbiBtn.UseVisualStyleBackColor = false;
            this.LocateUbiBtn.Click += new System.EventHandler(this.LocateUbiBtn_Click);
            // 
            // UbiPathTB
            // 
            this.UbiPathTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.UbiPathTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UbiPathTB.DefaultText = "";
            this.UbiPathTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UbiPathTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UbiPathTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UbiPathTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UbiPathTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UbiPathTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UbiPathTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UbiPathTB.ForeColor = System.Drawing.Color.White;
            this.UbiPathTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UbiPathTB.Location = new System.Drawing.Point(12, 101);
            this.UbiPathTB.Name = "UbiPathTB";
            this.UbiPathTB.PasswordChar = '\0';
            this.UbiPathTB.PlaceholderText = "";
            this.UbiPathTB.ReadOnly = true;
            this.UbiPathTB.SelectedText = "";
            this.UbiPathTB.Size = new System.Drawing.Size(102, 22);
            this.UbiPathTB.TabIndex = 12;
            this.UbiPathTB.TextChanged += new System.EventHandler(this.UbiPathTB_TextChanged);
            // 
            // LocateR6Btn
            // 
            this.LocateR6Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocateR6Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LocateR6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocateR6Btn.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.LocateR6Btn.ForeColor = System.Drawing.Color.White;
            this.LocateR6Btn.Location = new System.Drawing.Point(120, 60);
            this.LocateR6Btn.Name = "LocateR6Btn";
            this.LocateR6Btn.Size = new System.Drawing.Size(32, 22);
            this.LocateR6Btn.TabIndex = 11;
            this.LocateR6Btn.Text = "...";
            this.LocateR6Btn.UseVisualStyleBackColor = false;
            this.LocateR6Btn.Click += new System.EventHandler(this.LocateR6Btn_Click);
            // 
            // R6PathTB
            // 
            this.R6PathTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.R6PathTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.R6PathTB.DefaultText = "";
            this.R6PathTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.R6PathTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.R6PathTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.R6PathTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.R6PathTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.R6PathTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.R6PathTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.R6PathTB.ForeColor = System.Drawing.Color.White;
            this.R6PathTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.R6PathTB.Location = new System.Drawing.Point(12, 60);
            this.R6PathTB.Name = "R6PathTB";
            this.R6PathTB.PasswordChar = '\0';
            this.R6PathTB.PlaceholderText = "";
            this.R6PathTB.ReadOnly = true;
            this.R6PathTB.SelectedText = "";
            this.R6PathTB.Size = new System.Drawing.Size(102, 22);
            this.R6PathTB.TabIndex = 10;
            this.R6PathTB.TextChanged += new System.EventHandler(this.R6PathTB_TextChanged);
            // 
            // AutoLoadSaveBtn
            // 
            this.AutoLoadSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AutoLoadSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AutoLoadSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoLoadSaveBtn.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoLoadSaveBtn.ForeColor = System.Drawing.Color.White;
            this.AutoLoadSaveBtn.Location = new System.Drawing.Point(6, 202);
            this.AutoLoadSaveBtn.Name = "AutoLoadSaveBtn";
            this.AutoLoadSaveBtn.Size = new System.Drawing.Size(152, 25);
            this.AutoLoadSaveBtn.TabIndex = 9;
            this.AutoLoadSaveBtn.Text = "Mount Save (Automatic)";
            this.AutoLoadSaveBtn.UseVisualStyleBackColor = false;
            this.AutoLoadSaveBtn.Click += new System.EventHandler(this.AutoLoadSaveBtn_Click);
            // 
            // LoadSaveBtn
            // 
            this.LoadSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LoadSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LoadSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSaveBtn.Font = new System.Drawing.Font("Verdana", 6.75F);
            this.LoadSaveBtn.ForeColor = System.Drawing.Color.White;
            this.LoadSaveBtn.Location = new System.Drawing.Point(6, 171);
            this.LoadSaveBtn.Name = "LoadSaveBtn";
            this.LoadSaveBtn.Size = new System.Drawing.Size(152, 25);
            this.LoadSaveBtn.TabIndex = 8;
            this.LoadSaveBtn.Text = "Mount Save (Manual)";
            this.LoadSaveBtn.UseVisualStyleBackColor = false;
            this.LoadSaveBtn.Click += new System.EventHandler(this.LoadSaveBtn_Click);
            // 
            // UserIDLbl
            // 
            this.UserIDLbl.AutoSize = true;
            this.UserIDLbl.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.UserIDLbl.ForeColor = System.Drawing.Color.White;
            this.UserIDLbl.Location = new System.Drawing.Point(9, 1);
            this.UserIDLbl.Name = "UserIDLbl";
            this.UserIDLbl.Size = new System.Drawing.Size(42, 16);
            this.UserIDLbl.TabIndex = 7;
            this.UserIDLbl.Text = "User:";
            // 
            // UserIDCB
            // 
            this.UserIDCB.BackColor = System.Drawing.Color.Transparent;
            this.UserIDCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.UserIDCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserIDCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UserIDCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIDCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIDCB.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UserIDCB.ForeColor = System.Drawing.Color.White;
            this.UserIDCB.ItemHeight = 18;
            this.UserIDCB.Location = new System.Drawing.Point(12, 17);
            this.UserIDCB.Name = "UserIDCB";
            this.UserIDCB.Size = new System.Drawing.Size(140, 24);
            this.UserIDCB.TabIndex = 6;
            // 
            // MiddlePnl
            // 
            this.MiddlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MiddlePnl.Controls.Add(this.panel1);
            this.MiddlePnl.Location = new System.Drawing.Point(4, 40);
            this.MiddlePnl.Name = "MiddlePnl";
            this.MiddlePnl.Size = new System.Drawing.Size(182, 287);
            this.MiddlePnl.TabIndex = 5;
            // 
            // SaveMounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(191, 331);
            this.Controls.Add(this.MiddlePnl);
            this.Controls.Add(this.FormDragBarPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveMounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveMounterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveMounterForm_FormClosing);
            this.Load += new System.EventHandler(this.SaveMounterForm_Load);
            this.FormDragBarPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MiddlePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel FormDragBarPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MiddlePnl;
        private System.Windows.Forms.Label UserIDLbl;
        private Guna.UI2.WinForms.Guna2ComboBox UserIDCB;
        private System.Windows.Forms.Button LoadSaveBtn;
        private System.Windows.Forms.Button AutoLoadSaveBtn;
        private System.Windows.Forms.Label UbiLocateLbl;
        private System.Windows.Forms.Label R6LocateLbl;
        private System.Windows.Forms.Button LocateUbiBtn;
        private Guna.UI2.WinForms.Guna2TextBox UbiPathTB;
        private System.Windows.Forms.Button LocateR6Btn;
        private Guna.UI2.WinForms.Guna2TextBox R6PathTB;
        private System.Windows.Forms.Label StatusDynamicLbl;
        private System.Windows.Forms.Label StatusStaticLbl;
    }
}