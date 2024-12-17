using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace SistemaLogin.Data
{
    internal class Connection
    {
        public static string server = "127.0.0.1";
        public static string dataBase = "Login";
        public static string user = "root";
        public static string contrasena = "123456";
        public static MySqlConnection connMaster = new MySqlConnection();
        public static void OpenConnection()
        {
            string connectionString = $"server={server};database={dataBase};user={user};password={contrasena};";
            
            connMaster = new MySqlConnection(connectionString);
            connMaster.Open();

            if(connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion establecida");
            }
            else
            {
                MessageBox.Show("No se ha conectado");
            }
        }
        public static void CloseConnection() {
        }

        }
}
