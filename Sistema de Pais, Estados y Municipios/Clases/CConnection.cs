using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Net.Configuration;

namespace Sistema_de_Pais__Estados_y_Municipios.Clases
{
    class CConnection
    {
        SqlConnection conn = new SqlConnection();
        static string server = "localhost";
        static string db = "us_paises";
        static string username = "us";
        static string password = "1234";
        static string port = "1433";

        string cadenaConexion = "Data Source = " + server + "," + port + ";"
            + "user id = " + username + ";"
            + "password =" + password + ";"
            + "Initial Catalog = " + db + ";"
            + "Persist Security info = true";

        public SqlConnection establecerConexion()
        {
            try
            {
                conn.ConnectionString = cadenaConexion;
                conn.Open();
                MessageBox.Show("Se conectó correctamente a la base de datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logró la conexión a la base de datos. " + e.Message.ToString());
            }
            return conn;
        }
    }
}
