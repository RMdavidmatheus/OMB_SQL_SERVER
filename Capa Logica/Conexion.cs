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
        private SqlConnection Conexion_base = new SqlConnection("Data Source=sql5035.site4now.net;Initial Catalog=DB_A44CDA_OMBSeguros;User ID=DB_A44CDA_OMBSeguros_admin;Password=DAVIDALE98");
        
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
