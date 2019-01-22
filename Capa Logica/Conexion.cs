using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Logica
{
    class Conexion
    {
        private SqlConnection Conexion_base = new SqlConnection("Server=(local);Database= OMB_Seguros; Integrated Security = true");
        
        // METODOS PARA CONECTAR Y DESCONECTAR LA BASE

        public SqlConnection Conectar()
        {
            if (Conexion_base.State == ConnectionState.Closed)
            {
                Conexion_base.Open();
            }
            return Conexion_base;
        }

        public SqlConnection Desconectar()
        {
            if (Conexion_base.State == ConnectionState.Open)
            {
                Conexion_base.Close();
            }
            return Conexion_base;
        }
    }
}
