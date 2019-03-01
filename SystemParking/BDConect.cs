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

        public  MySqlConnection Conexion() {

            MySqlConnection conexion = new MySqlConnection("server=localhost; database=parking; Uid=root; pwd=;");

            conexion.Open();
            return conexion;
        }
    }
}
