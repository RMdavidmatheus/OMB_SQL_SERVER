using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Omb_SQL_SERVER.Alert
{
    public partial class Alert : Form
    {
        public Alert(string message, AlertType type)
        {
            InitializeComponent();
            Label_Alert.Text = message;

            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    Icon.Image = imageList1.Images[1];
                    break;

                case AlertType.error:
                    this.BackColor = Color.Firebrick;
                    Icon.Image = imageList1.Images[0];
                    break;

                case AlertType.info:
                    this.BackColor = Color.Gray;
                    Icon.Image = imageList1.Images[3];
                    break;

                case AlertType.warning:
                    this.BackColor = Color.DarkOrange;
                    Icon.Image = imageList1.Images[2];
                    break;
            }
            this.TopMost = true;
        }

        public enum AlertType
        {
            success,info,warning,error
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.CloseAlert.Start();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 30;

            Show.Start();
        }

        private void Label_Alert_Click(object sender, EventArgs e)
        {
            
        }

        private void Timeout_Tick(object sender, EventArgs e)
        {
            CloseAlert.Start();
        }

        int interval = 0;

        // show transition
        private void Show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                Show.Stop();
            }
        }

        private void CloseAlert_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity-= 0.1;
            }
            else
            {
                this.Close();
            }
        }
        /// <summary>
        /// Alerts the specified message.
        /// </summary>
        /// <param name="_message">The message</param>
        /// <param name="type" >The Type.</param>
        public static void Show_Alert_Message(string message,AlertType type)
        {
            new Alert(message, type).Show(); 
        }
    }
}
