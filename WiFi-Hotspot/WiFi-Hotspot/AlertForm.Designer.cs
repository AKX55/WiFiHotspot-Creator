namespace WiFi_Hotspot
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.rtext_Logs = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(61, 30);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(58, 30);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Alert";
            // 
            // rtext_Logs
            // 
            this.rtext_Logs.BackColor = System.Drawing.Color.DarkGray;
            this.rtext_Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtext_Logs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtext_Logs.ForeColor = System.Drawing.Color.White;
            this.rtext_Logs.Location = new System.Drawing.Point(25, 66);
            this.rtext_Logs.Name = "rtext_Logs";
            this.rtext_Logs.ReadOnly = true;
            this.rtext_Logs.Size = new System.Drawing.Size(320, 200);
            this.rtext_Logs.TabIndex = 8;
            this.rtext_Logs.Text = "";
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(370, 297);
            this.Controls.Add(this.rtext_Logs);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlertForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox rtext_Logs;
    }
}