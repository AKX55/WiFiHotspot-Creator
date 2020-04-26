namespace WiFi_Hotspot
{
    partial class EditForm
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

        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ssid = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.textBox_ssid = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.linklbl_save = new System.Windows.Forms.LinkLabel();
            this.lbl_err = new System.Windows.Forms.Label();
            this.btn_randomize = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_randomize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(61, 30);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(132, 30);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Edit Hotspot";
            // 
            // lbl_ssid
            // 
            this.lbl_ssid.AutoSize = true;
            this.lbl_ssid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ssid.ForeColor = System.Drawing.Color.White;
            this.lbl_ssid.Location = new System.Drawing.Point(50, 115);
            this.lbl_ssid.Name = "lbl_ssid";
            this.lbl_ssid.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_ssid.Size = new System.Drawing.Size(50, 20);
            this.lbl_ssid.TabIndex = 8;
            this.lbl_ssid.Text = "SSID: ";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_key.ForeColor = System.Drawing.Color.White;
            this.lbl_key.Location = new System.Drawing.Point(50, 165);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.lbl_key.Size = new System.Drawing.Size(50, 20);
            this.lbl_key.TabIndex = 9;
            this.lbl_key.Text = "KEY: ";
            // 
            // textBox_ssid
            // 
            this.textBox_ssid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ssid.ForeColor = System.Drawing.Color.Gray;
            this.textBox_ssid.Location = new System.Drawing.Point(106, 110);
            this.textBox_ssid.Name = "textBox_ssid";
            this.textBox_ssid.Size = new System.Drawing.Size(210, 27);
            this.textBox_ssid.TabIndex = 10;
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.ForeColor = System.Drawing.Color.Gray;
            this.textBox_key.Location = new System.Drawing.Point(106, 160);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(210, 27);
            this.textBox_key.TabIndex = 11;
            // 
            // linklbl_save
            // 
            this.linklbl_save.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklbl_save.AutoSize = true;
            this.linklbl_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklbl_save.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linklbl_save.LinkColor = System.Drawing.Color.White;
            this.linklbl_save.Location = new System.Drawing.Point(275, 235);
            this.linklbl_save.Name = "linklbl_save";
            this.linklbl_save.Size = new System.Drawing.Size(40, 20);
            this.linklbl_save.TabIndex = 12;
            this.linklbl_save.TabStop = true;
            this.linklbl_save.Text = "Save";
            this.linklbl_save.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Save_LinkClicked);
            // 
            // lbl_err
            // 
            this.lbl_err.AutoSize = true;
            this.lbl_err.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_err.ForeColor = System.Drawing.Color.White;
            this.lbl_err.Location = new System.Drawing.Point(50, 237);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(0, 19);
            this.lbl_err.TabIndex = 13;
            // 
            // btn_randomize
            // 
            this.btn_randomize.BackColor = System.Drawing.SystemColors.Window;
            this.btn_randomize.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.Random;
            this.btn_randomize.Location = new System.Drawing.Point(289, 160);
            this.btn_randomize.Name = "btn_randomize";
            this.btn_randomize.Size = new System.Drawing.Size(27, 27);
            this.btn_randomize.TabIndex = 14;
            this.btn_randomize.TabStop = false;
            this.btn_randomize.Click += new System.EventHandler(this.Random_Click);
            this.btn_randomize.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_randomize_Paint);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::WiFi_Hotspot.Properties.Resources.Arrow;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(25, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 6;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Close_Click);
            this.btn_back.MouseEnter += new System.EventHandler(this.Button_MouseHover);
            this.btn_back.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(370, 297);
            this.Controls.Add(this.btn_randomize);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.linklbl_save);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_ssid);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_ssid);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_randomize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_ssid;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.TextBox textBox_ssid;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.LinkLabel linklbl_save;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.PictureBox btn_randomize;
    }
}