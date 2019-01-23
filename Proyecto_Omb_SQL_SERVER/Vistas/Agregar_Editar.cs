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
    public partial class Agregar_Editar : MaterialForm
    {
        public Agregar_Editar()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;

            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Blue900, Primary.Blue800,
                Primary.Teal900, Accent.Teal700,
                TextShade.WHITE);
            Vehiculo_tab.Parent = null;

        }
        // DOUBLES PARA BASE DE DATOS
        private double num, num_2;

        //  INSTANCIANDO METODOS
        Capa_Logica.Logica_Metodos Metodos = new Capa_Logica.Logica_Metodos();
        //  .......

        // INSTANCIANDO FECHAS
        Calendar_Date_Picker Fechas = new Calendar_Date_Picker();

        private void Guardar_Tom_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Doc_Tom.Text == "")
            {
                MessageBox.Show("Ingrese un documento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Nom_Tom.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Ape_Tom.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Direccion_Tom.Text == "")
            {
                MessageBox.Show("Ingrese una direcciòn", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Tel_Tom.Text == "")
            {
                MessageBox.Show("Ingrese un telèfono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Email_Tom.Text == "")
            {
                MessageBox.Show("Ingrese un email", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fecha_Nacimiento_Tom.Text == "Fecha de nacimiento...")
            {
                MessageBox.Show("Ingrese una fecha de nacimiento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            // ----------- INSERT EN TABLA TOMADOR SIEMPRE Y CUANDO NO CUMPLA CON LA CONDICION ANTERIOR
            else
            {
                string query = "INSERT INTO Tomador (Tom_Documento,Tom_Tip_Doc,Tom_Nombres,Tom_Apellidos,Tom_Direccion,Tom_Telefono,Tom_Email,Tom_Fecha_Nacimiento)" +
                    " VALUES('" + Txt_Doc_Tom.Text + "','" + Drop_Tp_Doc_Tom.selectedValue.ToString() + "','" + Txt_Nom_Tom.Text + "','" + Txt_Ape_Tom.Text + "','" + Txt_Direccion_Tom.Text + "','" + Txt_Tel_Tom.Text + "','" + Txt_Email_Tom.Text + "','" + Txt_Fecha_Nacimiento_Tom.Text + "')";

                if (Metodos.Insertar(query))
                {
                    MessageBox.Show("Tomador Ingresado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido_control.SelectedTab = Beneficiario_tab;
                }
                else
                {
                    MessageBox.Show("Error al ingresar Tomador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void Pb_Calendar_Tom_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFecha(Txt_Fecha_Nacimiento_Tom);
        }

        private void PB_Calendar_Ben_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFecha(Txt_Fecha_Nacimiento_Ben);
        }

        private void Guardar_Ben_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Doc_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un documento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Nom_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Ape_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Dir_Ben.Text == "")
            {
                MessageBox.Show("Ingrese una direcciòn", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Tel_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un telèfono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Email_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un email", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fecha_Nacimiento_Ben.Text == "Fecha de nacimiento...")
            {
                MessageBox.Show("Ingrese una fecha de nacimiento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            // ----------- INSERT EN TABLA BENEFICIARIO SIEMPRE Y CUANDO NO CUMPLA CON LA CONDICION ANTERIOR
            else
            {
                string query = "INSERT INTO Beneficiario (Ben_Documento,Ben_Tipo_Doc,Ben_Nombres,Ben_Apellidos,Ben_Direccion,Ben_Telefono,Ben_Email,Ben_Fecha_Nacimiento)" +
                    " VALUES('" + Txt_Doc_Ben.Text + "','" + TP_Doc_Ben.selectedValue.ToString() + "','" + Txt_Nom_Ben.Text + "','" + Txt_Ape_Ben.Text + "','" + Txt_Dir_Ben.Text + "','" + Txt_Tel_Ben.Text + "','" + Txt_Email_Ben.Text + "','" + Txt_Fecha_Nacimiento_Ben.Text + "')";

                if (Metodos.Insertar(query))
                {
                    MessageBox.Show("Beneficiario Ingresado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido_control.SelectedTab = Poliza_tab;
                }
                else
                {
                    MessageBox.Show("Error al ingresar Beneficiario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        //  EVENTO BOTON POLIZA GUARDAR
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_No_Poliza.Text == "")
            {
                MessageBox.Show("Ingrese un numero de poliza", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Fecha_inicial.Text == "Fecha inicial...")
            {
                MessageBox.Show("Ingrese una fecha inicial de vigencia", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Fecha_final.Text == "Fecha final...")
            {
                MessageBox.Show("Ingrese una fecha final de vigencia", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Valor_Prima.Text == "")
            {
                MessageBox.Show("Ingrese un valor de prima", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            // ----------- INSERT EN TABLA POLIZA SIEMPRE Y CUANDO NO CUMPLA CON LA CONDICION ANTERIOR
            else
            {
                // SUSTRAYENDO INDEX DE LOS COMBOBOX

                int Index_Ramo = CB_Ramo.selectedIndex + 1;
                int Index_Ase = CB_Aseguradora.selectedIndex + 1;

                // CORRIGIENDO EL VALOR DE PRIMA SIN COMILLAS
                double Valor_Prima_Corregido = Convert.ToDouble(Txt_Valor_Prima.Text);

                // QUERY
                string query = "INSERT INTO Poliza (Pol_Numero_Poliza,Tipo_Poliza_ID,Aseguradora_ID,Tomador_Documento,Beneficiario_Documento,Pol_Vigencia_Inicial,Pol_Vigencia_Final,Pol_Valor_Prima)" +
                    " VALUES('" + Txt_No_Poliza.Text + "','" + Index_Ramo.ToString() + "','" + Index_Ase.ToString() + "','" + Txt_Doc_Tom.Text + "','" + Txt_Doc_Ben.Text + "','" + Fecha_inicial.Text + "','" + Fecha_final.Text + "','" + Valor_Prima_Corregido.ToString() + "')";

                if (Metodos.Insertar(query))
                {
                    MessageBox.Show("Poliza Ingresada correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // CONDICINANDO EL REDIRECCIONAMIENTO Y HABILITANDO VEHICULO SI CUMPLE
                    if (CB_Ramo.selectedValue == "AUTOS")
                    {
                        Vehiculo_tab.Parent = Contenido_control;
                        Contenido_control.SelectedTab = Vehiculo_tab;
                    }
                    else
                    {
                        // NO SE ACOPLA LA TAB VEHICULO
                    }
                }
                else
                {
                    MessageBox.Show("Error al ingresar Poliza", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void img_Calendar_Pol_1_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFecha(Fecha_inicial);
        }

        private void img_Calendar_2_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFecha(Fecha_final);
        }

        private void PB_Calendar_Soat_Click(object sender, EventArgs e)
        {
            Fechas.ShowDialog();
            Fechas.MandarFecha(Txt_Vig_Soat);
        }

        private void Guardar_Veh_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Placa.Text == "")
            {
                MessageBox.Show("Ingrese una placa", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Modelo.Text == "")
            {
                MessageBox.Show("Ingrese un modelo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fasecolda.Text == "")
            {
                MessageBox.Show("Ingrese un fasecolda", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Servicio.Text == "")
            {
                MessageBox.Show("Ingrese un servicio del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Clase.Text == "")
            {
                MessageBox.Show("Ingrese una clase del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Marca.Text == "")
            {
                MessageBox.Show("Ingrese una marca", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Valor_Auto.Text == "")
            {
                MessageBox.Show("Ingrese un valor del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Vig_Soat.Text == "Vigencia SOAT")
            {
                MessageBox.Show("Ingrese una vigencia para el soat", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            // ----------- INSERT EN TABLA VEHICULO SIEMPRE Y CUANDO NO CUMPLA CON LA CONDICION ANTERIOR
            else
            {
                // VALOR DEL AUTO CORRECTO, SIN COMAS
                double Valor_Auto_Corregido = Convert.ToDouble(Txt_Valor_Auto.Text);

                // QUERY
                string query = "INSERT INTO Vehiculo (Veh_Placa,Veh_Modelo,Veh_Fasecolda,Veh_Servicio,Veh_Clase,Veh_Marca,Veh_Valor_Auto,Veh_Vigencia_Soat)" +
                    " VALUES('" + Txt_Placa.Text + "','" + Txt_Modelo.Text + "','" + Txt_Fasecolda.Text + "','" + Txt_Servicio.Text + "','" + Txt_Clase.Text + "','" + Txt_Marca.Text + "','" + Valor_Auto_Corregido.ToString() + "','" + Txt_Vig_Soat.Text + "')";

                if (Metodos.Insertar(query))
                {
                    MessageBox.Show("Vehiculo Ingresado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // HACIENDO RELACION CON TABLA POL_VEH AUTOMATICAMENTE

                    string query2 = "INSERT INTO Polizas_Vehiculos (PolVeh_Numero_Poliza,PolVeh_Veh_Placa) VALUES('"+Txt_No_Poliza.Text+"','"+Txt_Placa.Text+"')";
                    Metodos.Insertar(query2);
                }
                else
                {
                    MessageBox.Show("Error al ingresar vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void Txt_Valor_Prima_TextChanged(object sender, EventArgs e)
        {
           // EVENTO QUE NO USAMOS :V ...
        }

        private void Txt_Valor_Prima_KeyUp(object sender, KeyEventArgs e)
        {

            if (double.TryParse(Txt_Valor_Prima.Text, out num))
            {
                Txt_Valor_Prima.Text = num.ToString("N0");
                Txt_Valor_Prima.SelectionStart = Txt_Valor_Prima.TextLength;
            }
            //double numero = Convert.ToDouble(Txt_Valor_Prima.Text);
            //Txt_Valor_Prima.Text = numero.ToString("N0");
            //Txt_Valor_Prima.SelectionStart = Txt_Valor_Prima.TextLength;
        }

        private void Txt_Valor_Auto_KeyUp(object sender, KeyEventArgs e)
        {

            if (double.TryParse(Txt_Valor_Auto.Text, out num_2))
            {
                Txt_Valor_Auto.Text = num_2.ToString("N0");
                Txt_Valor_Auto.SelectionStart = Txt_Valor_Auto.TextLength;
            }
            //double numero = Convert.ToDouble(Txt_Valor_Auto.Text);
            //Txt_Valor_Auto.Text = numero.ToString("N0");
            //Txt_Valor_Auto.SelectionStart = Txt_Valor_Auto.TextLength;
        }

        private void Agregar_Editar_Load(object sender, EventArgs e)
        {
            // MASCARA DE MILES EN EL TXT BOX VALOR PRIMA

            if (double.TryParse(Txt_Valor_Prima.Text, out num))
            {
                Txt_Valor_Prima.Text = num.ToString("N0");
                Txt_Valor_Prima.SelectionStart = Txt_Valor_Prima.TextLength;
            }
            // MASCARA DE MILES EN EL TXT BOX VALOR AUTO

            if (double.TryParse(Txt_Valor_Auto.Text, out num_2))
            {
                Txt_Valor_Auto.Text = num_2.ToString("N0");
                Txt_Valor_Auto.SelectionStart = Txt_Valor_Auto.TextLength;
            }
        }

        private void Act_Tom_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Placa.Text == "")
            {
                MessageBox.Show("Ingrese una placa", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Modelo.Text == "")
            {
                MessageBox.Show("Ingrese un modelo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fasecolda.Text == "")
            {
                MessageBox.Show("Ingrese un fasecolda", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Servicio.Text == "")
            {
                MessageBox.Show("Ingrese un servicio del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Clase.Text == "")
            {
                MessageBox.Show("Ingrese una clase del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Marca.Text == "")
            {
                MessageBox.Show("Ingrese una marca", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Valor_Auto.Text == "")
            {
                MessageBox.Show("Ingrese un valor del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Vig_Soat.Text == "Vigencia SOAT")
            {
                MessageBox.Show("Ingrese una vigencia para el soat", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // FINALIZACION VALIDACION CAMPOS VACIOS
            else
            {
                // UPDATE DATOS TOM
                string query = "UPDATE Tomador Set Tom_Tip_Doc='" + Drop_Tp_Doc_Tom.selectedValue.ToString() + "', Tom_Nombres='" + Txt_Nom_Tom.Text + "',Tom_Apellidos='" + Txt_Ape_Tom.Text + "',Tom_Direccion='" + Txt_Direccion_Tom.Text + "',Tom_Telefono='" + Txt_Tel_Tom.Text + "',Tom_Email='" + Txt_Email_Tom.Text + "',Tom_Fecha_Nacimiento='" + Txt_Fecha_Nacimiento_Tom.Text + "' WHERE Tom_Documento='" + Txt_Doc_Tom.Text + "'";

                if (Metodos.Actualizar(query))
                {
                    MessageBox.Show("Tomador actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido_control.SelectedTab = Beneficiario_tab;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Tomador", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // FINALIZACION DEL UPDATE
            }
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

        private void Act_Ben_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Doc_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un documento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Nom_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Ape_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un apellido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Dir_Ben.Text == "")
            {
                MessageBox.Show("Ingrese una direcciòn", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Tel_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un telèfono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Email_Ben.Text == "")
            {
                MessageBox.Show("Ingrese un email", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fecha_Nacimiento_Ben.Text == "Fecha de nacimiento...")
            {
                MessageBox.Show("Ingrese una fecha de nacimiento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            else
            {
                //  ACTUALIZANDO BENEFICIARIO

                string query = "UPDATE Beneficiario Set Ben_Tipo_Doc='" + TP_Doc_Ben.selectedValue.ToString() + "', Ben_Nombres='" + Txt_Nom_Ben.Text + "',Ben_Apellidos='" + Txt_Ape_Ben.Text + "',Ben_Direccion='" + Txt_Dir_Ben.Text + "',Ben_Telefono='" + Txt_Tel_Ben.Text + "',Ben_Email='" + Txt_Email_Ben.Text + "',Ben_Fecha_Nacimiento='" + Txt_Fecha_Nacimiento_Ben.Text + "' WHERE Ben_Documento='" + Txt_Doc_Ben.Text + "'";
                if (Metodos.Actualizar(query))
                {
                    MessageBox.Show("Beneficiario actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Contenido_control.SelectedTab = Poliza_tab;
                }
                else
                {
                    MessageBox.Show("Error al actualizar Beneficiario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void Act_Veh_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_Placa.Text == "")
            {
                MessageBox.Show("Ingrese una placa", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Modelo.Text == "")
            {
                MessageBox.Show("Ingrese un modelo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Fasecolda.Text == "")
            {
                MessageBox.Show("Ingrese un fasecolda", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Servicio.Text == "")
            {
                MessageBox.Show("Ingrese un servicio del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Clase.Text == "")
            {
                MessageBox.Show("Ingrese una clase del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Marca.Text == "")
            {
                MessageBox.Show("Ingrese una marca", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Valor_Auto.Text == "")
            {
                MessageBox.Show("Ingrese un valor del auto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Vig_Soat.Text == "Vigencia SOAT")
            {
                MessageBox.Show("Ingrese una vigencia para el soat", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            else
            {
                string query = "UPDATE Vehiculo Set Veh_Modelo='" + Txt_Modelo.Text + "', Veh_Fasecolda='" + Txt_Fasecolda.Text + "',Veh_Servicio='" + Txt_Servicio.Text + "',Veh_Clase='" + Txt_Clase.Text + "',Veh_Marca='" + Txt_Marca.Text + "',Veh_Valor_Auto='" + num_2.ToString() + "',Veh_Vigencia_Soat='" + Txt_Vig_Soat.Text + "' WHERE Veh_Placa='" + Txt_Placa.Text + "'";
                if (Metodos.Actualizar(query))
                {
                    MessageBox.Show("Vehiculo actualizado correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar Vehiculo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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

        private void Act_Pol_Click(object sender, EventArgs e)
        {
            // VALIDACION DATOS VACIOS
            if (Txt_No_Poliza.Text == "")
            {
                MessageBox.Show("Ingrese un numero de poliza", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Fecha_inicial.Text == "Fecha inicial...")
            {
                MessageBox.Show("Ingrese una fecha inicial de vigencia", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Fecha_final.Text == "Fecha final...")
            {
                MessageBox.Show("Ingrese una fecha final de vigencia", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Txt_Valor_Prima.Text == "")
            {
                MessageBox.Show("Ingrese un valor de prima", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // TERMINA AQUI LAS VALIDACIONES DE DATOS VACIOS
            // UPDATE POLIZA
            string query = "UPDATE Poliza Set Pol_Vigencia_Inicial='" + Fecha_inicial.Text + "', Pol_Vigencia_Final='" + Fecha_final.Text + "',Pol_Valor_Prima='" + num.ToString() + "' WHERE Pol_Numero_Poliza='" + Txt_No_Poliza.Text + "'";

            if (Metodos.Actualizar(query))
            {
                MessageBox.Show("Actualizo la poliza correctamente", "SATISFACTORIO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (CB_Ramo.selectedValue.Equals("AUTOS"))
                {
                    // MOSTRANDO TAB SI ES TIPO DE POLIZA AUTOS
                    Vehiculo_tab.Parent = Contenido_control;
                    Contenido_control.SelectedTab = Vehiculo_tab;
                }
                else
                {
                    this.Close(); //NO MODIFICA EL PROCESO SI NO CUMPLE LA CONDICION
                }
            }
            else
            {
                MessageBox.Show("Error al actualizar la poliza", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
}   
