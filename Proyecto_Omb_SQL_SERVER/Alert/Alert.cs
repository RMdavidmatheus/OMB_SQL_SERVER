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

            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    break;

                case AlertType.error:
                    this.BackColor = Color.Firebrick;
                    break;

                case AlertType.info:
                    this.BackColor = Color.Gray;
                    break;

                case AlertType.warning:
                    this.BackColor = Color.DarkOrange;
                    break;
            }
        }

        public enum AlertType
        {
            success,info,warning,error
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
