namespace SumTing_Special
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FormDragBarPnl = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiddlePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnlockerBtn = new System.Windows.Forms.Button();
            this.SaveMounterBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.WebsiteBtn = new System.Windows.Forms.Button();
            this.R6SPB = new System.Windows.Forms.PictureBox();
            this.DiscordBtn = new System.Windows.Forms.Button();
            this.ExpandTmr = new System.Windows.Forms.Timer(this.components);
            this.FormDragBarPnl.SuspendLayout();
            this.MiddlePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R6SPB)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDragBarPnl
            // 
            this.FormDragBarPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.FormDragBarPnl.Controls.Add(this.MinimizeBtn);
            this.FormDragBarPnl.Controls.Add(this.ExitBtn);
            this.FormDragBarPnl.Location = new System.Drawing.Point(0, 0);
            this.FormDragBarPnl.Name = "FormDragBarPnl";
            this.FormDragBarPnl.Size = new System.Drawing.Size(198, 34);
            this.FormDragBarPnl.TabIndex = 0;
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
            this.MinimizeBtn.Location = new System.Drawing.Point(144, 6);
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
            this.ExitBtn.Location = new System.Drawing.Point(169, 6);
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
            this.MiddlePnl.Location = new System.Drawing.Point(8, 43);
            this.MiddlePnl.Name = "MiddlePnl";
            this.MiddlePnl.Size = new System.Drawing.Size(182, 317);
            this.MiddlePnl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.UnlockerBtn);
            this.panel1.Controls.Add(this.SaveMounterBtn);
            this.panel1.Controls.Add(this.AboutBtn);
            this.panel1.Controls.Add(this.WebsiteBtn);
            this.panel1.Controls.Add(this.R6SPB);
            this.panel1.Controls.Add(this.DiscordBtn);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 299);
            this.panel1.TabIndex = 4;
            // 
            // UnlockerBtn
            // 
            this.UnlockerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.UnlockerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.UnlockerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockerBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockerBtn.ForeColor = System.Drawing.Color.White;
            this.UnlockerBtn.Location = new System.Drawing.Point(6, 125);
            this.UnlockerBtn.Name = "UnlockerBtn";
            this.UnlockerBtn.Size = new System.Drawing.Size(152, 25);
            this.UnlockerBtn.TabIndex = 9;
            this.UnlockerBtn.Text = "Unlocker";
            this.UnlockerBtn.UseVisualStyleBackColor = false;
            this.UnlockerBtn.Click += new System.EventHandler(this.UnlockerBtn_Click);
            // 
            // SaveMounterBtn
            // 
            this.SaveMounterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SaveMounterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.SaveMounterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMounterBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveMounterBtn.ForeColor = System.Drawing.Color.White;
            this.SaveMounterBtn.Location = new System.Drawing.Point(6, 156);
            this.SaveMounterBtn.Name = "SaveMounterBtn";
            this.SaveMounterBtn.Size = new System.Drawing.Size(152, 25);
            this.SaveMounterBtn.TabIndex = 8;
            this.SaveMounterBtn.Text = "Save Mounter";
            this.SaveMounterBtn.UseVisualStyleBackColor = false;
            this.SaveMounterBtn.Click += new System.EventHandler(this.SaveMounterBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutBtn.ForeColor = System.Drawing.Color.White;
            this.AboutBtn.Location = new System.Drawing.Point(6, 267);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(152, 25);
            this.AboutBtn.TabIndex = 6;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = false;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // WebsiteBtn
            // 
            this.WebsiteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WebsiteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.WebsiteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WebsiteBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteBtn.ForeColor = System.Drawing.Color.White;
            this.WebsiteBtn.Location = new System.Drawing.Point(6, 236);
            this.WebsiteBtn.Name = "WebsiteBtn";
            this.WebsiteBtn.Size = new System.Drawing.Size(152, 25);
            this.WebsiteBtn.TabIndex = 5;
            this.WebsiteBtn.Text = "Website";
            this.WebsiteBtn.UseVisualStyleBackColor = false;
            this.WebsiteBtn.Click += new System.EventHandler(this.WebsiteBtn_Click);
            // 
            // R6SPB
            // 
            this.R6SPB.Image = global::SumTing_Special.Properties.Resources.R6S;
            this.R6SPB.Location = new System.Drawing.Point(-8, 3);
            this.R6SPB.Name = "R6SPB";
            this.R6SPB.Size = new System.Drawing.Size(181, 114);
            this.R6SPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.R6SPB.TabIndex = 3;
            this.R6SPB.TabStop = false;
            // 
            // DiscordBtn
            // 
            this.DiscordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DiscordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.DiscordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordBtn.ForeColor = System.Drawing.Color.White;
            this.DiscordBtn.Location = new System.Drawing.Point(6, 205);
            this.DiscordBtn.Name = "DiscordBtn";
            this.DiscordBtn.Size = new System.Drawing.Size(152, 25);
            this.DiscordBtn.TabIndex = 4;
            this.DiscordBtn.Text = "Discord";
            this.DiscordBtn.UseVisualStyleBackColor = false;
            this.DiscordBtn.Click += new System.EventHandler(this.DiscordBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(198, 367);
            this.Controls.Add(this.MiddlePnl);
            this.Controls.Add(this.FormDragBarPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Made by vPurpp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormDragBarPnl.ResumeLayout(false);
            this.MiddlePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.R6SPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormDragBarPnl;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel MiddlePnl;
        private System.Windows.Forms.PictureBox R6SPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DiscordBtn;
        private System.Windows.Forms.Button WebsiteBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Timer ExpandTmr;
        private System.Windows.Forms.Button UnlockerBtn;
        private System.Windows.Forms.Button SaveMounterBtn;
    }
}

