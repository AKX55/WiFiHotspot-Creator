using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WiFi_Hotspot
{
    using static Program;

    public partial class MainForm : Form
    {
        Point onMouseDown_Point = Point.Empty;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Minimize_MouseClick(object obj, EventArgs evt)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Close_MouseClick(object sender, EventArgs e)
        {
            ExecuteCommand("python", string.Format("hotspot-win32.py stop"));
            this.Close();
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

        private void OnPaint(object obj, PaintEventArgs evt)
        {
            Pen pen = new Pen(Color.FromArgb(150, 150, 150), 1);
            Rectangle rectangle = new Rectangle(0, 0, 369, 514);
            evt.Graphics.DrawRectangle(pen, rectangle);
        }

        private void OnMouseDown(object obj, MouseEventArgs evt)
        {
            onMouseDown_Point = new Point(evt.X, evt.Y);
        }
        private void OnMouseUp(object obj, MouseEventArgs evt)
        {
            onMouseDown_Point = Point.Empty;
        }
        private void OnMouseMove(object obj, MouseEventArgs evt)
        {
            if (!onMouseDown_Point.IsEmpty)
            {
                this.Location = new Point(this.Location.X + (evt.X - onMouseDown_Point.X), this.Location.Y + (evt.Y - onMouseDown_Point.Y));
            }
        }


        List<string> logs = new List<string>();
        private void ExecuteCommand(string command, string arguments)
        {
            bool errorFound = false;
            bool hotspotSupported = true;

            Process processInstance = new Process();
            processInstance.StartInfo = new ProcessStartInfo
            {
                FileName = command,
                Arguments = arguments,
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
                    logs.Add(evt.Data);

                    if (logs.Last().Substring(0, 4) == "[ER]")
                    {
                        errorFound = true;
                        if(logs.Last().Contains("Hotspot Not Supported on WiFi Card"))
                        {
                            hotspotSupported = false;
                            logs.Add(string.Format("[{0}] Applicaion will now Exit!", DateTime.Now));
                        }
                    }
                }
            };
            processInstance.WaitForExit();
            
            if (errorFound) 
            {
                AlertForm alertForm = new AlertForm("Error Found!", logs.ToArray());
                alertForm.ShowDialog();

                if (!hotspotSupported)
                    this.Close();
            }
            else
            {
                lbl_status.Text = "Hotspot Started!";
            }
        }

        /*
         * Will run only once, at the start of the program
         * It is used instead of Form_Load so that the MainForm is
         * fully loaded.
         */
        private void OnLoad(object obj, EventArgs evt)
        {
            if (!(File.Exists(Directory.GetCurrentDirectory() + "\\hotspot-win32.py") ||
                File.Exists(Directory.GetCurrentDirectory() + "\\random-all.py")))
            {
                string[] error_log = { string.Format("[Err][{0}] Script(s) Missing!", DateTime.Now), string.Format("[{0}] Applicaion will now Exit!", DateTime.Now) };
                AlertForm alertForm = new AlertForm("Files Missing!", error_log);
                alertForm.ShowDialog();
                this.Close();
            }
            else
            {

                ExecuteCommand("python", string.Format("hotspot-win32.py start \"{0}\" \"{1}\"", ssid, key));
                lbl_ssid.Text = string.Format("SSID: {0}", ssid);
                lbl_key.Text = string.Format("KEY:  {0}", key);

                this.Activated -= new EventHandler(OnLoad);
                this.Activated += new EventHandler(OnActivated);
            }
        }
        private void OnActivated(object obj, EventArgs evt)
        {
            lbl_ssid.Text = string.Format("SSID: {0}", ssid);
            lbl_key.Text = string.Format("KEY:  {0}", key);
        }

        private void Logs_LinkClicked(object obj, LinkLabelLinkClickedEventArgs evt)
        {
            AlertForm logForm = new AlertForm("Logs", logs.ToArray());
            logForm.ShowDialog();
        }

        private void Help_LinkClicked(object obj, LinkLabelLinkClickedEventArgs evt)
        {
            string[] textData = @"File Name: WiFi-Hotspot

Description:

 -This application is written in C# accompanied with 2 scripts written in Python. These script is required for the Hotspot to be established and to generate a Security Key for the Hotspot. 

Email me: aka@programmer.net".Split("\n".ToCharArray());
            AlertForm helpForm = new AlertForm("About", textData);
            helpForm.ShowDialog();
        }

        private void Edit_LinkedClicked(object obj, LinkLabelLinkClickedEventArgs evt)
        {
            EditForm editForm = new EditForm(ssid, key);
            editForm.ShowDialog();

            if (editForm.isWifiChanged)
            {
                ExecuteCommand("python", string.Format("hotspot-win32.py stop"));
                ExecuteCommand("python", string.Format("hotspot-win32.py start \"{0}\" \"{1}\"", ssid, key));

                lbl_status.Text = "Hotspot Restarted!";
            }
        }

    }
}
