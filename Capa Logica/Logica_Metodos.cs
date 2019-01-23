using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica
{
    public class Logica_Metodos
    {
        // INSTANCIANDO CONECTOR
        Conexion Conexion = new Conexion();

        // METODO PARA LLENAR UN PANEL CON UN FORMULARIO HIJO
        public void Abrir_Formulario_En_Panel(Panel Panel_Receptor, object Formulario_Hijo)
        {
            if (Panel_Receptor.Controls.Count >= 0)
            {
                Panel_Receptor.Controls.Clear();
                Form fh = Formulario_Hijo as Form;

                if (fh.Visible == true)
                {
                    fh.BringToFront();
                }
                else
                {
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    Panel_Receptor.Controls.Add(fh);
                    Panel_Receptor.Tag = fh;
                    fh.Show();
                }
            }
        }
        // METODO PARA LLENAR DATAGRID LISTADO DE POLIZAS
        public void LlenarTabla_Poliza(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_Listado_Polizas", Conexion.Conectar());
                SqlDataAdapter rs = new SqlDataAdapter(query);
                DataTable dt = new DataTable();
                rs.Fill(dt);
                Llenar.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexion.Desconectar();
        }
        // METODO PARA INSERT
        public bool Insertar(string query)
        {
            bool Insertado = false;
            try
            {
                int registros = 0;
                SqlCommand sentencia = new SqlCommand(query, Conexion.Conectar());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Insertado = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexion.Desconectar();
            return Insertado;
        }
        // METODO PARA ACTUALIZAR
        public bool Actualizar(string query)
        {
            bool Actualizado = false;
            try
            {
                int registros = 0;
                SqlCommand sentencia = new SqlCommand(query, Conexion.Conectar());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Actualizado = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexion.Desconectar();
            return Actualizado;
        }
        // METODO PARA SUSTRAER INFORMACION DESDE LA BASE DE DATOS.. TABLA POLIZA
        public DataTable Extraer_Pol(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE POLIZA
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select p.Tipo_Poliza_ID , p.Aseguradora_ID, p.Pol_Valor_Prima from Poliza p where p.Pol_Numero_Poliza = '" + Num_pol + "' ", Conexion.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        // METODOS PARA EXTRAER INFORMACION DESDE LA BASE DE DATOS.. TABLA POLVEH
        public DataTable Extraer_Pol_Veh(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE POLIZA DE VEHICULOS
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select * from Polizas_Vehiculos p where p.PolVeh_Numero_Poliza = '" + Num_pol + "' ", Conexion.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        // METODO PARA EXTRAER INFORMACION DESDE LA BASE DE DATOS.. TABLA VEHICULO
        public DataTable Extraer_Veh(string Placa)
        {
            // TOMANDO DATOS CONCRETOS DE VEHICULOS
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select * from Vehiculo v where v.Veh_Placa = '" + Placa + "' ", Conexion.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        // METODO PARA EXTRAER INFORMACION DE LA TABLA TOMADOR
        public DataTable Extraer_Tom(string DocumentoTomador)
        {
            //TOMANDO DATOS CONCRETOS DE TOMADOR

            DataTable dt = new DataTable();

            SqlCommand query = new SqlCommand("select * from Tomador tom where tom.Tom_Documento = '" + DocumentoTomador + "' ", Conexion.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        // METODO PARA EXTRAER INFORMACION DE LA TABLA BENEFICIARIO
        public DataTable Extraer_Ben(string DocumentoBeneficiario)
        {
            // TOMANDO DATOS CONCRETOS DE BENEFICIARIO
            DataTable dt = new DataTable();
            SqlCommand query = new  SqlCommand("select * from Beneficiario ben where ben.Ben_Documento = '" + DocumentoBeneficiario + "' ", Conexion.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
    }
}
