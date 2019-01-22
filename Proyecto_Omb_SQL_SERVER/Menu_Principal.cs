using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        // VARIABLES PRIVADAS
        private string Usuario_Titulo_Barra;

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
            }
            else
            {
                Animacion_logo.HideSync(pictureBox2);
                Panel_Menu.Visible = false;
                Panel_Menu.Width = 60;
                Menu_Animacion.ShowSync(Panel_Menu);
            }
        }
    }
}
