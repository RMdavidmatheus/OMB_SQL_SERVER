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
        // METODO PARA LLENAR DATAGRID LISTADO DE VEHICULOS
        public void LlenarTabla_Vehiculos(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_Vehiculos", Conexion.Conectar());
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
        // METODO PARA LLENAR DATAGRID TOMADORES
        public void LlenarTabla_Tomador(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_Tomador", Conexion.Conectar());
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
        // METODO PARA LLENAR DATAGRID BENEFICIARIOS
        public void LlenarTabla_Beneficiario(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_Beneficiario", Conexion.Conectar());
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
        // METODO PARA LLENAR DATAGRID REPORTE SOAT
        public void LlenarTabla_SOAT(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_reporte_soat", Conexion.Conectar());
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
        // METODO PARA LLENAR DATAGRID REPORTE VIGENCIAS
        public void LlenarTabla_Vigencia(DataGridView Llenar)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT* from Vista_reporte_vigencias", Conexion.Conectar());
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
        // METODO PARA ELIMINAR
        public bool Eliminar(string query)
        {
            bool Eliminado = false;
            try
            {
                int registros = 0;
                SqlCommand sentencia = new SqlCommand(query, Conexion.Conectar());
                registros = sentencia.ExecuteNonQuery();
                if (registros > 0)
                {
                    Eliminado = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexion.Desconectar();
            return Eliminado;
        }
        // METODO PARA SUSTRAER INFORMACION DESDE LA BASE DE DATOS.. TABLA POLIZA
        public DataTable Extraer_Pol(string Num_pol)
        {
            // TOMANDO DATOS CONCRETOS DE POLIZA
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select * from Poliza p where p.Pol_Numero_Poliza = '" + Num_pol + "' ", Conexion.Conectar());
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
        // METODO PARA BUSCAR POLIZA
        public void Buscar_Poliza(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("select * from Vista_Listado_Polizas vi where vi.[Numero de Poliza] LIKE '" + TextoBusqueda + "%' or vi.[Documento Tomador] LIKE '" + TextoBusqueda + "%' or vi.[Documento Beneficiario] LIKE '" + TextoBusqueda + "%' OR vi.[Nombres Tomador] LIKE '" + TextoBusqueda + "%' OR vi.[Nombres Beneficiario] LIKE '" + TextoBusqueda + "%'", Conexion.Desconectar());
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
        // METODO PARA BUSCAR TOMADOR
        public void Buscar_Tom(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Vista_Tomador t WHERE t.Documento LIKE '" + TextoBusqueda + "%' OR t.Nombres LIKE '" + TextoBusqueda + "%' OR t.Email LIKE '" + TextoBusqueda + "%' ", Conexion.Conectar());
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
        // METODO PARA BUSCAR BENEFICIARIO
        public void Buscar_Ben(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Vista_Beneficiario b WHERE b.Documento LIKE '" + TextoBusqueda + "%' OR b.Nombres LIKE '" + TextoBusqueda + "%' OR b.Email LIKE '" + TextoBusqueda + "%'  ", Conexion.Conectar());
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
        // METODO PARA BUSCAR VEHICULO
        public void Buscar_Vehiculo(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Vista_Vehiculos v WHERE v.Placa LIKE '" + TextoBusqueda + "%' OR v.[Numero de Poliza] LIKE '" + TextoBusqueda + "%' OR v.[Documento Tomador] LIKE '" + TextoBusqueda + "%'", Conexion.Conectar());
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
        // METODO PARA BUSCAR EN REPORTE
        public void Reporte_SOAT_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("select * from vigencia_soat_mes vs where vs.Placa LIKE '" + TextoBusqueda + "%' OR vs.`N.Poliza` LIKE '" + TextoBusqueda + "%' OR vs.`Documento Tomador`LIKE '" + TextoBusqueda + "%' OR vs.`Nombres Tomador` LIKE '" + TextoBusqueda + "%' ", Conexion.Conectar());
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
        // METODO PARA BUSCAR VIG POLIZA
        public void Reporte_Vigencia_Poliza_Buscar(DataGridView Llenar, string TextoBusqueda)
        {
            try
            {
                SqlCommand query = new SqlCommand("SELECT * FROM Vista_reporte_vigencias vpa WHERE vpa.[Nombres Tomador] LIKE '" + TextoBusqueda + "%' OR vpa.[Numero de poliza] LIKE '" + TextoBusqueda + "%' OR vpa.Documento LIKE '" + TextoBusqueda + "%' AND vpa.[Estado de la poliza]='ACTIVO'", Conexion.Conectar());
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
    }
}
