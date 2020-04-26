namespace WiFi_Hotspot
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_ssid = new System.Windows.Forms.Panel();
            this.lbl_ssid = new System.Windows.Forms.Label();
            this.panel_key = new System.Windows.Forms.Panel();
            this.lbl_key = new System.Windows.Forms.Label();
            this.picBox_WiFi = new System.Windows.Forms.PictureBox();
            this.linkLbl_Logs = new System.Windows.Forms.LinkLabel();
            this.linkLbl_Help = new System.Windows.Forms.LinkLabel();
            this.linkLbl_Edit = new System.Windows.Forms.LinkLabel();
            this.btn_maximize = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel_ssid.SuspendLayout();
            this.panel_key.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_WiFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ssid
            // 
            this.panel_ssid.BackColor = System.Drawing.Color.Transparent;
            this.panel_ssid.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.Box;
            this.panel_ssid.Controls.Add(this.lbl_ssid);
            this.panel_ssid.Location = new System.Drawing.Point(65, 282);
            this.panel_ssid.Name = "panel_ssid";
            this.panel_ssid.Size = new System.Drawing.Size(240, 50);
            this.panel_ssid.TabIndex = 0;
            // 
            // lbl_ssid
            // 
            this.lbl_ssid.AutoSize = true;
            this.lbl_ssid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_ssid.Location = new System.Drawing.Point(20, 15);
            this.lbl_ssid.Name = "lbl_ssid";
            this.lbl_ssid.Size = new System.Drawing.Size(44, 20);
            this.lbl_ssid.TabIndex = 0;
            this.lbl_ssid.Text = "SSID:";
            // 
            // panel_key
            // 
            this.panel_key.BackColor = System.Drawing.Color.Transparent;
            this.panel_key.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.Box;
            this.panel_key.Controls.Add(this.lbl_key);
            this.panel_key.Location = new System.Drawing.Point(65, 352);
            this.panel_key.Name = "panel_key";
            this.panel_key.Size = new System.Drawing.Size(240, 50);
            this.panel_key.TabIndex = 1;
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_key.Location = new System.Drawing.Point(20, 15);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(43, 20);
            this.lbl_key.TabIndex = 1;
            this.lbl_key.Text = "KEY: ";
            // 
            // picBox_WiFi
            // 
            this.picBox_WiFi.BackColor = System.Drawing.Color.Transparent;
            this.picBox_WiFi.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.WiFi_Logo;
            this.picBox_WiFi.Location = new System.Drawing.Point(113, 121);
            this.picBox_WiFi.Name = "picBox_WiFi";
            this.picBox_WiFi.Size = new System.Drawing.Size(144, 125);
            this.picBox_WiFi.TabIndex = 2;
            this.picBox_WiFi.TabStop = false;
            // 
            // linkLbl_Logs
            // 
            this.linkLbl_Logs.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLbl_Logs.AutoSize = true;
            this.linkLbl_Logs.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Logs.LinkColor = System.Drawing.Color.Gray;
            this.linkLbl_Logs.Location = new System.Drawing.Point(288, 491);
            this.linkLbl_Logs.Name = "linkLbl_Logs";
            this.linkLbl_Logs.Size = new System.Drawing.Size(32, 15);
            this.linkLbl_Logs.TabIndex = 3;
            this.linkLbl_Logs.TabStop = true;
            this.linkLbl_Logs.Text = "Logs";
            this.linkLbl_Logs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logs_LinkClicked);
            // 
            // linkLbl_Help
            // 
            this.linkLbl_Help.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLbl_Help.AutoSize = true;
            this.linkLbl_Help.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Help.LinkColor = System.Drawing.Color.Gray;
            this.linkLbl_Help.Location = new System.Drawing.Point(326, 491);
            this.linkLbl_Help.Name = "linkLbl_Help";
            this.linkLbl_Help.Size = new System.Drawing.Size(32, 15);
            this.linkLbl_Help.TabIndex = 4;
            this.linkLbl_Help.TabStop = true;
            this.linkLbl_Help.Text = "Help";
            this.linkLbl_Help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Help_LinkClicked);
            // 
            // linkLbl_Edit
            // 
            this.linkLbl_Edit.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLbl_Edit.AutoSize = true;
            this.linkLbl_Edit.BackColor = System.Drawing.Color.Transparent;
            this.linkLbl_Edit.LinkColor = System.Drawing.Color.Gray;
            this.linkLbl_Edit.Location = new System.Drawing.Point(255, 491);
            this.linkLbl_Edit.Name = "linkLbl_Edit";
            this.linkLbl_Edit.Size = new System.Drawing.Size(27, 15);
            this.linkLbl_Edit.TabIndex = 5;
            this.linkLbl_Edit.TabStop = true;
            this.linkLbl_Edit.Text = "Edit";
            this.linkLbl_Edit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Edit_LinkedClicked);
            // 
            // btn_maximize
            // 
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.close;
            this.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximize.Location = new System.Drawing.Point(315, 30);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_maximize.TabIndex = 6;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.Close_MouseClick);
            this.btn_maximize.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.btn_maximize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.minimize;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Location = new System.Drawing.Point(279, 30);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.Minimize_MouseClick);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_status.Location = new System.Drawing.Point(12, 491);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(10, 15);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = ".";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.Background_New;
            this.ClientSize = new System.Drawing.Size(370, 515);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_maximize);
            this.Controls.Add(this.linkLbl_Edit);
            this.Controls.Add(this.linkLbl_Help);
            this.Controls.Add(this.linkLbl_Logs);
            this.Controls.Add(this.picBox_WiFi);
            this.Controls.Add(this.panel_key);
            this.Controls.Add(this.panel_ssid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.OnLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.panel_ssid.ResumeLayout(false);
            this.panel_ssid.PerformLayout();
            this.panel_key.ResumeLayout(false);
            this.panel_key.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_WiFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ssid;
        private System.Windows.Forms.Panel panel_key;
        private System.Windows.Forms.PictureBox picBox_WiFi;
        private System.Windows.Forms.LinkLabel linkLbl_Logs;
        private System.Windows.Forms.LinkLabel linkLbl_Help;
        private System.Windows.Forms.LinkLabel linkLbl_Edit;
        private System.Windows.Forms.Label lbl_ssid;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.PictureBox btn_maximize;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.Label lbl_status;
    }
}

