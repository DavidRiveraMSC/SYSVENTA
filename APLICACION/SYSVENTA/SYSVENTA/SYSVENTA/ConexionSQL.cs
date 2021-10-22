using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace SYSVENTA
{
    class ConexionSQL
    {
        //CONEXION CON SQL SERVER
        private static string cadena = "server="+ConfigurationManager.AppSettings["CONEXIONSQL"]+";database=SYSVENTAS;integrated security=true";
        public SqlConnection Cx = new SqlConnection(cadena);
        public void abrirConexion()
        {
            try
            {
                Cx.Open();
                //MessageBox.Show("CONEXION REALIZADA CON EXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public void cerraConexion()
        {
            try
            {
                Cx.Close();
                //MessageBox.Show("CONEXION CERRADA REALIZADA CON EXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
