﻿using MaterialSkin;
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
    public partial class Listado_Beneficiarios : MaterialForm
    {
        public Listado_Beneficiarios()
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
            DataGrid_Listado_Ben.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // INSTANCIANDO METODOS
        Capa_Logica.Logica_Metodos Metodos = new Capa_Logica.Logica_Metodos();

        private void Listado_Beneficiarios_Load(object sender, EventArgs e)
        {
            Metodos.LlenarTabla_Beneficiario(DataGrid_Listado_Ben);
        }
    }
}
