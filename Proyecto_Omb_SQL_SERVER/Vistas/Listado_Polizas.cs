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

        /*SELECCION DE ID ASE Y TIPO POLIZA*/
        private int seleccionTP, seleccionAse;
        private string DocumentoBen;
        private string DocumentoTom;
        private string PlacaVeh;

        private void Listado_Polizas_Load(object sender, EventArgs e)
        {
            Metodos.LlenarTabla_Poliza(DataGrid_Listado_Polizas);
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            Agregar_Editar Añadir = new Agregar_Editar();
            Añadir.Text = "Añadir datos";
            Añadir.Act_Tom.Visible = false;
            Añadir.Act_Ben.Visible = false;
            Añadir.Act_Pol.Visible = false;
            Añadir.Act_Veh.Visible = false;
            Añadir.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Agregar_Editar Editar = new Agregar_Editar();
            Editar.Text = "Editar datos";
            // .......

            if (DataGrid_Listado_Polizas.SelectedRows.Count > 0)
            {
                // OCULTANDO BOTON GUARDAR, EVITANDO MODIFICAR LLAVES PRIMARIAS DEL REGISTRO...
                Editar.Guardar_Tom.Visible = false;
                Editar.Guardar_Ben.Visible = false;
                Editar.materialRaisedButton1.Visible = false;
                Editar.Guardar_Veh.Visible = false;
                Editar.Txt_Doc_Tom.Enabled = false;
                Editar.Txt_Doc_Ben.Enabled = false;
                Editar.Txt_No_Poliza.Enabled = false;
                Editar.Txt_Placa.Enabled = false;

                // EXTRAYENDO DATOS DESDE EL DATAGRID PARA LLENAR DATOS AL ACTUALIZAR
                Editar.Txt_Doc_Tom.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[4].Value.ToString();

                //  CONDICIONAL SEGUN VALOR DE LA BASE EN TABLA TOMADOR....
                if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "CEDULA")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 0;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "NIT")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 1;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "PASAPORTE")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 2;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "TARJETA DE IDENTIDAD")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 3;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "REGISTRO CIVIL")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 4;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[3].Value.ToString() == "CEDULA EXTRANJERA")
                {
                    Editar.Drop_Tp_Doc_Tom.selectedIndex = 5;
                }

                // FIN CONDICIONAL

                //  CONDICIONAL SEGUN VALOR DE LA BASE EN TABLA BENEFICIARIO....
                if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "CEDULA")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 0;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "NIT")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 1;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "PASAPORTE")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 2;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "TARJETA DE IDENTIDAD")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 3;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "REGISTRO CIVIL")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 4;
                }
                else if (DataGrid_Listado_Polizas.CurrentRow.Cells[6].Value.ToString() == "CEDULA EXTRANJERA")
                {
                    Editar.TP_Doc_Ben.selectedIndex = 5;
                }

                // FIN CONDICIONAL

                Editar.Txt_Doc_Ben.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[7].Value.ToString();

                Editar.TP_Doc_Ben.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[8].Value.ToString();

                Editar.Txt_No_Poliza.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[0].Value.ToString();

                Editar.Fecha_inicial.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[9].Value.ToString();

                Editar.Fecha_final.Text = DataGrid_Listado_Polizas.CurrentRow.Cells[10].Value.ToString();

                // EXTRAYENDO DATOS QUE NO ESTAN EN EL DATAGRID, POLIZA
                DataTable dt4 = Metodos.Extraer_Pol(Editar.Txt_No_Poliza.Text);
                if (dt4.Rows.Count > 0)
                {
                    DataRow row = dt4.Rows[0];
                    seleccionTP = Convert.ToInt32(row["Tipo_Poliza_ID"]);
                    seleccionAse = Convert.ToInt32(row["Aseguradora_ID"]);
                    Editar.CB_Ramo.selectedIndex = seleccionTP -1;
                    Editar.CB_Aseguradora.selectedIndex = seleccionAse -1;
                    Editar.Txt_Valor_Prima.Text = Convert.ToString(row["Pol_Valor_Prima"]);
                }
                //PONIENDO VISIBLE LA PESTAÑA VEHICULO CUANDO LA POLIZA ES EXCLUSIVAMENTE DE AUTOS
                if (Editar.CB_Ramo.selectedValue.Equals("AUTOS"))
                {
                    Editar.Vehiculo_tab.Parent = Editar.Contenido_control;
                    //EXTRAYENDO PLACA DE LA POLIZA PARA ACTUALIZAR DATOS DEL VEHICULO
                    DataTable dt1 = Metodos.Extraer_Pol_Veh(Editar.Txt_No_Poliza.Text);
                    if (dt1.Rows.Count > 0)
                    {
                        DataRow row = dt1.Rows[0];
                        PlacaVeh = Convert.ToString(row["PolVeh_Veh_Placa"]);
                        Editar.Txt_Placa.Text = PlacaVeh;
                    }
                    // EXTRAYENDO DATOS DE LA TABLA VEHICULOS
                    DataTable dt9 = Metodos.Extraer_Veh(PlacaVeh);
                    if (dt9.Rows.Count > 0)
                    {
                        DataRow row = dt9.Rows[0];

                        Editar.Txt_Modelo.Text = Convert.ToString(row["Veh_Modelo"]);
                        Editar.Txt_Fasecolda.Text = Convert.ToString(row["Veh_Fasecolda"]);
                        Editar.Txt_Servicio.Text = Convert.ToString(row["Veh_Servicio"]);
                        Editar.Txt_Clase.Text = Convert.ToString(row["Veh_Clase"]);
                        Editar.Txt_Marca.Text = Convert.ToString(row["Veh_Marca"]);
                        Editar.Txt_Valor_Auto.Text = Convert.ToString(row["Veh_Valor_Auto"]);
                        // FORMATO DE FECHA VIG SOAT
                        Editar.Txt_Vig_Soat.Text = Convert.ToDateTime(row["Veh_Vigencia_Soat"]).ToString("yyyy-MM-dd");
                    }
                }

                //EXTRAYENDO DATOS FALTANTES DESDE LA BASE DE DATOS, TOMADOR
                DataTable dt2 = Metodos.Extraer_Tom(Editar.Txt_Doc_Tom.Text);
                if (dt2.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0];
                    Editar.Txt_Nom_Tom.Text = Convert.ToString(row["Tom_Nombres"]);

                    Editar.Txt_Ape_Tom.Text = Convert.ToString(row["Tom_Apellidos"]);

                    Editar.Txt_Direccion_Tom.Text = Convert.ToString(row["Tom_Direccion"]);

                    Editar.Txt_Tel_Tom.Text = Convert.ToString(row["Tom_Telefono"]);

                    Editar.Txt_Email_Tom.Text = Convert.ToString(row["Tom_Email"]);

                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    Editar.Txt_Fecha_Nacimiento_Tom.Text = Convert.ToDateTime(row["Tom_Fecha_Nacimiento"]).ToString("yyyy-MM-dd");
                }

                //EXTRAYENDO DATOS FALTANTES DESDE LA BASE DE DATOS, BENEFICIARIO
                DataTable dt3 = Metodos.Extraer_Ben(Editar.Txt_Doc_Ben.Text);
                if (dt3.Rows.Count > 0)
                {
                    DataRow row = dt3.Rows[0];
                    Editar.Txt_Nom_Ben.Text = Convert.ToString(row["Ben_Nombres"]);

                    Editar.Txt_Ape_Ben.Text = Convert.ToString(row["Ben_Apellidos"]);

                    Editar.Txt_Dir_Ben.Text = Convert.ToString(row["Ben_Direccion"]);

                    Editar.Txt_Tel_Ben.Text = Convert.ToString(row["Ben_Telefono"]);

                    Editar.Txt_Email_Ben.Text = Convert.ToString(row["Ben_Email"]);

                    // CONVIRTIENDO A FORMATO DE FECHA CORRECTO
                    Editar.Txt_Fecha_Nacimiento_Ben.Text = Convert.ToDateTime(row["Ben_Fecha_Nacimiento"]).ToString("yyyy-MM-dd");
                }
                Editar.ShowDialog();
                // RESTAURANDO VALORES
                PlacaVeh = "";
                //RESTAURANDO VALORES A LAS VARIABLES
                seleccionTP = 0;
                seleccionAse = 0;
            }
            else
            {
                MessageBox.Show("Seleccione una columna", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // REFRESCANDO TABLA
            if (Editar.Visible == false)
            {
                Metodos.LlenarTabla_Poliza(DataGrid_Listado_Polizas);
                // ACTUALIZAR AUTOMATICAMENTE POLIZA SI ESTA ACTIVA O INACTIVA
                string PolqueryActivo = "UPDATE Poliza SET Pol_Estado = 'ACTIVO' where Pol_Vigencia_Final >= GETDATE()";
                Metodos.Insertar(PolqueryActivo);
                string PolqueryInactivo = "UPDATE Poliza SET Pol_Estado = 'INACTIVO' where Pol_Vigencia_Final < GETDATE()";
                Metodos.Insertar(PolqueryInactivo);
                // FINALIZACION POLIZA UPDATE

                //ACTUALIZAR ACTIVO O INACTIVO EN VEHICULOS
                string SOATqueryActivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'ACTIVO' where Veh_Vigencia_Soat >= GETDATE()";
                Metodos.Insertar(SOATqueryActivo);
                string SOATqueryInactivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'INACTIVO' where Veh_Vigencia_Soat < GETDATE()";
                Metodos.Insertar(SOATqueryInactivo);
                // FIN 
            }
            else
            {
                Metodos.LlenarTabla_Poliza(DataGrid_Listado_Polizas);
                // ACTUALIZAR AUTOMATICAMENTE POLIZA SI ESTA ACTIVA O INACTIVA
                string PolqueryActivo = "UPDATE Poliza SET Pol_Estado = 'ACTIVO' where Pol_Vigencia_Final >= GETDATE()";
                Metodos.Insertar(PolqueryActivo);
                string PolqueryInactivo = "UPDATE Poliza SET Pol_Estado = 'INACTIVO' where Pol_Vigencia_Final < GETDATE()";
                Metodos.Insertar(PolqueryInactivo);
                // FINALIZACION POLIZA UPDATE

                //ACTUALIZAR ACTIVO O INACTIVO EN VEHICULOS
                string SOATqueryActivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'ACTIVO' where Veh_Vigencia_Soat >= GETDATE()";
                Metodos.Insertar(SOATqueryActivo);
                string SOATqueryInactivo = "UPDATE Vehiculo SET Veh_Soat_Estado = 'INACTIVO' where Veh_Vigencia_Soat < GETDATE()";
                Metodos.Insertar(SOATqueryInactivo);
                // FIN 
            }
        }

        private void DataGrid_Listado_Polizas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGrid_Listado_Polizas.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {


                        if (e.Value.ToString().Equals("ACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.LightGreen;

                        }

                        if (e.Value.ToString().Equals("INACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.IndianRed;
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
