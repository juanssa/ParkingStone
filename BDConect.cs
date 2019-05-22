using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SystemParking
{
    public class BDConect
    {

        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        public  MySqlConnection Conexion() {

            server = "localhost";
            port = "3306";
            database = "parking";
            uid = "root";
            password = "";

            string connectionString;

            connectionString = "SERVER=" + server + ";"+ "PORT="+port+";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            MySqlConnection conexion = new MySqlConnection(connectionString);

            //MySqlConnection conexion = new MySqlConnection("server=localhost; database=parking; Uid=root; pwd=;");

            conexion.Open();
            return conexion;
        }
    }
}
