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

namespace Proyecto_Omb_SQL_SERVER.Vistas
{
    public partial class Listado_Polizas : MaterialForm
    {
        public Listado_Polizas()
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
            DataGrid_Listado_Polizas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DataGrid_Listado_Polizas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // INSTANCIANDO METODOS

        Capa_Logica.Logica_Metodos Metodos = new Capa_Logica.Logica_Metodos();

        private void Listado_Polizas_Load(object sender, EventArgs e)
        {
            Metodos.LlenarTabla_Poliza(DataGrid_Listado_Polizas);
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            Agregar_Editar Añadir = new Agregar_Editar();
            Añadir.Text = "Añadir datos";
            Añadir.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Agregar_Editar Editar = new Agregar_Editar();
            Editar.Text = "Editar datos";
            Editar.ShowDialog();
        }
    }
}
