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
    public partial class Calendar_Date_Picker : MaterialForm
    {
        public Calendar_Date_Picker()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;

            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Indigo800, Primary.Indigo900,
                Primary.Indigo800, Accent.Cyan700,
                TextShade.WHITE);

            // FORMAT DATE PICKER
            DatePicker_Fecha.Format = DateTimePickerFormat.Custom;
            DatePicker_Fecha.FormatCustom = "yyyy-MM-dd";
        }

        public void MandarFecha(MaterialSingleLineTextField Receptor)
        {
            Receptor.Text = DatePicker_Fecha.Value.ToString("yyyy-MM-dd");
        }

        private void Guardar_Date_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fecha ingresada correctamente","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
