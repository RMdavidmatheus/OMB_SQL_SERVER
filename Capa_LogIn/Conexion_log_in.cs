using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_LogIn
{
    public class Conexion_log_in
    {
        // CONFUGURACION DE LA BASE DE DATOS SQL SERVER

        private SqlConnection Conexion_Log_In = new SqlConnection("Server=(local);Database= OMB_Seguros;Integrated Security=true");

        // METODOS PARA CONECTAR O DESCONECTAR
        public SqlConnection Conectar()
        {
            if (Conexion_Log_In.State == ConnectionState.Closed)
            {
                Conexion_Log_In.Open();
            }
            return Conexion_Log_In;
        }

        public SqlConnection Desconectar()
        {
            if (Conexion_Log_In.State == ConnectionState.Open)
            {
                Conexion_Log_In.Close();
            }
            return Conexion_Log_In;
        }
    }
}
