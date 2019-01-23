using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Omb_SQL_SERVER
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(string Usuario_BD)
        {
            InitializeComponent();
            Usuario_Titulo_Barra = Usuario_BD;
        }

        // METODO MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN METODO MOVER PANTALLA

        // VARIABLES PRIVADAS
        private string Usuario_Titulo_Barra;
        private int LX, LY;

        // INSTANCIANDO LA CLASE PARA TRAER METODOS

        Capa_Logica.Logica_Metodos Metodos = new Capa_Logica.Logica_Metodos();

        private void Cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Listado_Polizas_Click(object sender, EventArgs e)
        {
            //OCULTANDO TITULOS
            Animacion_TXTS.HideSync(Arrow);
            Animacion_TXTS.HideSync(Titulo);
            // TOMANDO EL TEXTO DEL BOTON
            Titulo.Text = btn_Listado_Polizas.Text;
            // MOSTRANDO ANIMACION
            Animacion_TXTS.ShowSync(Arrow);
            Animacion_TXTS.ShowSync(Titulo);

            // ABRIENDO FORMULARIO EN EL PANEL CONTENIDO.....
            Metodos.Abrir_Formulario_En_Panel(Panel_contenido,new Vistas.Listado_Polizas());

        }

        private void Menu_Principal_Click(object sender, EventArgs e)
        {
            // NADA AQUI
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Arrow.Hide();
            Titulo.Hide();
            Bienvenida.Text = "Bienvenido/a "+Usuario_Titulo_Barra;
            // INSTANCIANDO BIENVENIDA FORM

            Metodos.Abrir_Formulario_En_Panel(Panel_contenido,new Vistas.Vista_Inicio());
        }

        private void btn_Tomadores_Click(object sender, EventArgs e)
        {
            // OCULTANDO TITULOS
            Animacion_TXTS.HideSync(Arrow);
            Animacion_TXTS.HideSync(Titulo);
            // TOMANDO TEXTO DEL BOTON
            Titulo.Text = btn_Tomadores.Text;
            // MOSTRANDO ANIMACION DE LOS TITULOS
            Animacion_TXTS.ShowSync(Arrow);
            Animacion_TXTS.ShowSync(Titulo);
            Metodos.Abrir_Formulario_En_Panel(Panel_contenido,new Vistas.Listado_Tomadores());
        }

        private void btn_Beneficiarios_Click(object sender, EventArgs e)
        {
            // OCULTANDO TITULOS
            Animacion_TXTS.HideSync(Arrow);
            Animacion_TXTS.HideSync(Titulo);
            // TOMANDO TEXTO DEL BOTON
            Titulo.Text = btn_Beneficiarios.Text;
            // MOSTRANDO ANIMACION DE LOS TITULOS
            Animacion_TXTS.ShowSync(Arrow);
            Animacion_TXTS.ShowSync(Titulo);
            Metodos.Abrir_Formulario_En_Panel(Panel_contenido,new Vistas.Listado_Beneficiarios());
        }

        private void btn_Vehiculos_Click(object sender, EventArgs e)
        {
            // OCULTANDO TITULOS
            Animacion_TXTS.HideSync(Arrow);
            Animacion_TXTS.HideSync(Titulo);
            // TOMANDO TEXTO DEL BOTON
            Titulo.Text = btn_Vehiculos.Text;
            // MOSTRANDO ANIMACION DE LOS TITULOS
            Animacion_TXTS.ShowSync(Arrow);
            Animacion_TXTS.ShowSync(Titulo);
            Metodos.Abrir_Formulario_En_Panel(Panel_contenido, new Vistas.Listado_Vehiculos());
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            // OCULTANDO TITULOS
            Animacion_TXTS.HideSync(Arrow);
            Animacion_TXTS.HideSync(Titulo);
            // TOMANDO TEXTO DEL BOTON
            Titulo.Text = btn_Reportes.Text;
            // MOSTRANDO ANIMACION DE LOS TITULOS
            Animacion_TXTS.ShowSync(Arrow);
            Animacion_TXTS.ShowSync(Titulo);
        }

        private void Menu_Boton_Click(object sender, EventArgs e)
        {
            // ANIMACION DEL MENU SLIDE
            if (Panel_Menu.Width==60)
            {
                Panel_Menu.Visible = false;
                Panel_Menu.Width = 300;
                Menu_Animacion_2.ShowSync(Panel_Menu);
                Animacion_logo.ShowSync(pictureBox2);
                Animacion_logo.ShowSync(Hora);
                Animacion_logo.ShowSync(Date);
            }
            else
            {
                Animacion_logo.HideSync(pictureBox2);
                Animacion_logo.HideSync(Hora);
                Animacion_logo.HideSync(Date);
                Panel_Menu.Visible = false;
                Panel_Menu.Width = 60;
                Menu_Animacion.ShowSync(Panel_Menu);
            }
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;

            this.Size = new Size(1280, 720);
            this.Location = new Point(LX, LY);
            Maximizar.Visible = true;
            Restaurar.Visible = false;
        }

        private void Panel_herramientas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Metodos.Abrir_Formulario_En_Panel(Panel_contenido,new Vistas.Vista_Inicio());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hora.Text = DateTime.Now.ToLongTimeString();
            this.Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }
    }
}
