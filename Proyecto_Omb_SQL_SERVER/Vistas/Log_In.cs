using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    public partial class Log_In : MaterialForm
    {
        public Log_In()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;

            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue900,
                Primary.Blue900, Accent.Blue400,
                TextShade.WHITE);
        }
        // DATOS DONDE ALMACENARE LOS USUARIOS Y CONTRASEÑAS PARA LOGUEAR..

        private string usutxtBox;
        private string contxtBox;
        private string UsuarioBD;
        private string ContraseñaBD;
        private string TomarUsu;

        // --- FIN DE LAS VARIABLES

            // DECLARACION DE LA CAPA LOG IN

        private Capa_LogIn.Metodos_Log_In Metodos_Log_In = new Capa_LogIn.Metodos_Log_In();

        // ARCHIVOS PARA MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN ARCHIVOS MOVER PANTALLA

        // NUMERO DE LA IMAGEN
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            // HAY 5 IMAGENES EL IF NOS RECORRERA LAS 5 IMAGENES EN EL TIMER
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            // DANDO LA RUTA DE LA CARPETA IMAGES
            Slider.ImageLocation = string.Format(@"C:\Users\David PC\source\repos\Proyecto_Omb_SQL_SERVER\Images\{0}.Jpg", imageNumber);
            imageNumber++;
        }

        private void Tiempo_Slider_Tick(object sender, EventArgs e)
        {
            // METODO SLIDER
            LoadNextImage();
        }

        private void Panel_Derecha_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                    Application.Exit();
            }
            else
            {

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            usutxtBox = Usuario_txt.Text;
            contxtBox = Pass_txt.Text;

            if (Usuario_txt.Text != "" || Pass_txt.Text != "")
            {
                DataTable ValidarDato = Metodos_Log_In.Validar_Ingreso_Log_In(usutxtBox, contxtBox);

                if (ValidarDato.Rows.Count > 0)
                {
                    DataRow row = ValidarDato.Rows[0];
                    UsuarioBD = Convert.ToString(row["Nombre_Usuario"]);
                    ContraseñaBD = Convert.ToString(row["Contraseña_Usuario"]);
                }

                if (Usuario_txt.Text.Equals(UsuarioBD) || Pass_txt.Text.Equals(ContraseñaBD))
                {
                    TomarUsu = UsuarioBD;
                    Loading_Form Cargando = new Loading_Form(TomarUsu);
                    Cargando.Show();
                    //Menu_Principal Menu = new Menu_Principal(TomarUsu);
                    //Menu.Show();
                    ContraseñaBD = "";
                    this.Hide();
                    UsuarioBD = "";
                    ContraseñaBD = "";
                }

                else if (Usuario_txt.Text != UsuarioBD || Pass_txt.Text != ContraseñaBD)
                {
                    Usuario_txt.Text = "";
                    Error_Usu.Text = "Error usuario incorrecto...";
                    Error_Usu.Visible = true;
                    Pass_txt.Text = "";
                    Error_Pass.Text = "Error contraseña incorrecta...";
                    Error_Pass.Visible = true;

                }

                TomarUsu = "";
            }
        }

        private void Recuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Vistas.Vista_Recuperar_Pass Rec = new Vista_Recuperar_Pass();
            Rec.ShowDialog();
        }
    }
}
