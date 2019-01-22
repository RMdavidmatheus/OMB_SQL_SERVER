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

    }
}
