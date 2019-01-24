using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    public partial class Loading_Form : Form
    {
        public Loading_Form(string Usuario)
        {
            InitializeComponent();
            Usu = Usuario;
        }

        private string Usu;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress.Value++;
            if (Progress.Value == Progress.MaxValue)
            {
                timer1.Stop();
                Menu_Principal Menu = new Menu_Principal(Usu);
                this.Hide();
                Menu.Show();
                MessageBox.Show("Bienvenido a nuestro aplicativo " + Usu, "INGRESO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
