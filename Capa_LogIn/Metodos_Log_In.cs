using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_LogIn
{
    public class Metodos_Log_In
    {
        Conexion_log_in Conexion_Log_In = new Conexion_log_in();

        // VARIABLES PARA ENVIAR CORREO ELECTRONICO
        private string Email, nombres, contrasena, mensaje;

        public DataTable Validar_Ingreso_Log_In(string Usuario, string Contraseña)
        {
            // TOMANDO DATOS CONCRETOS DE USUARIOS
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select usu.Nombre_Usuario, usu.Contraseña_Usuario From Usuarios usu where usu.Nombre_Usuario='"+Usuario+"' and usu.Contraseña_Usuario='"+Contraseña+"'", Conexion_Log_In.Conectar() );
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);


            return dt;
        }
        public string Metodo_Recuperar_Contrasena(string DocumentoUsu)
        {
            // TOMANDO DATOS CONCRETOS DEL USUARIO
            DataTable dt = new DataTable();
            SqlCommand query = new SqlCommand("select * from Usuarios usu where usu.Documento_Usuario = '" + DocumentoUsu + "' ", Conexion_Log_In.Conectar());
            SqlDataAdapter rs = new SqlDataAdapter(query);
            rs.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Email = Convert.ToString(row["Email_Usuario"]);
                nombres = Convert.ToString(row["Nombre_Usuario"]);
                contrasena = Convert.ToString(row["Contraseña_Usuario"]);
                //ENVIANDO EMAIL
                EnviarEmail();
                mensaje = "Estimad@ " + nombres + " , se envio su contraseña al correo: " + Email + " , verifique su bandeja de entrada";
            }
            else
            {
                mensaje = "El usuario no existe en nuestras bases de datos";
            }

            return mensaje;
        }
        public void EnviarEmail()
        {
            // ESTRUCTURA DEL CORREO
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("millos2013returns@gmail.com");
            Correo.To.Add(Email);
            Correo.Subject = ("RECUPERACION DE CONTRASEÑA");
            Correo.Body = "Bienvenido " + nombres + " a nuestro sistema de recuperacion de contraseñas\n Su contraseña es: " + contrasena + " \n Esperamos haya sido de ayuda, gracias por usar nuestros servicios.";
            Correo.Priority = MailPriority.High;
            // CONFIGURANDO PROTOCOLO DE TRANSFERENCIA SMTP
            SmtpClient ServerEmail = new SmtpClient();
            ServerEmail.Credentials = new NetworkCredential("millos2013returns@gmail.com", "DAVIDALE98");
            ServerEmail.Host = "smtp.gmail.com";
            ServerEmail.Port = 587;
            ServerEmail.EnableSsl = true;
            try
            {
                ServerEmail.Send(Correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ENVIAR EMAIL " + ex.Message);
            }
            Correo.Dispose();
        }
    }
}
