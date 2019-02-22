using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Vista_Recuperar_Pass : MaterialForm
    {
        public Vista_Recuperar_Pass()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;

            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue900, Accent.Blue400,
                TextShade.WHITE);
        }

        // INSTANCIANDO METODOS

        Capa_LogIn.Metodos_Log_In Metodos = new Capa_LogIn.Metodos_Log_In();

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Metodos.Metodo_Recuperar_Contrasena(Txt_Doc.Text));
            Alert.Alert.Show_Alert_Message("Contraseña recuperada",Alert.Alert.AlertType.success);
        }
    }
}
