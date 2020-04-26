using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFi_Hotspot
{
    public partial class AlertForm : Form
    {

        public AlertForm(string title, string[] text)
        {
            InitializeComponent();
            lbl_title.Text = title;
            
            foreach(string item in text)
            {
                rtext_Logs.Text += string.Format("{0}\n", item);
            }
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
    }
}
