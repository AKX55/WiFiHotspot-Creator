using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Hotspot
{
    using static Program;

    public partial class EditForm : Form
    {
        public bool isWifiChanged = false;

        public EditForm(string ssid, string key)
        {
            InitializeComponent();

            textBox_ssid.Text = ssid;
            textBox_key.Text = key;
        }
        private void Button_MouseHover(object obj, EventArgs evt)
        {
            PictureBox pictureBox = (PictureBox)obj;
            pictureBox.BackColor = Color.FromArgb(25, 0, 0, 0);
        }
        private void Button_MouseLeave(object obj, EventArgs evt)
        {
            PictureBox pictureBox = (PictureBox)obj;
            pictureBox.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void Close_Click(object obj, EventArgs evt)
        {
            this.Close();
        }

        List<string> listRandomKeys = new List<string>();
        internal void GetRandomTextFromScript()
        {
            Process processInstance = new Process();
            processInstance.StartInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "random-all.py 8 true true true",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Minimized,
                CreateNoWindow = true
            };

            processInstance.Start();
            processInstance.BeginOutputReadLine();
            processInstance.OutputDataReceived += (obj, evt) =>
            {
                if (evt.Data != null)
                {
                    listRandomKeys.Add(evt.Data);
                }
            };
            processInstance.WaitForExit();
        }

        private void Random_Click(object obj, EventArgs evt)
        {
            GetRandomTextFromScript();
            textBox_key.Text = listRandomKeys.LastOrDefault();
        }

        private void Save_LinkClicked(object obj, LinkLabelLinkClickedEventArgs evt)
        {
            if (textBox_key.Text.Length < 8)
            {
                lbl_err.Text = "Key must be at least 8 Characters!";
            }
            else
            {
                if (!(ssid == textBox_ssid.Text && key == textBox_key.Text))
                {
                    isWifiChanged = true;

                    ssid = textBox_ssid.Text;
                    key = textBox_key.Text;
                }

                this.Close();
            }
        }

        private void btn_randomize_Paint(object obj, PaintEventArgs evt)
        {
            Pen pen = new Pen(Color.FromArgb(150, 150, 150), 1);
            Rectangle rectangle = new Rectangle(0, 0, 26, 26);
            evt.Graphics.DrawRectangle(pen, rectangle);
        }
    }
}