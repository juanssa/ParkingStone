using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SystemParking
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                /// Se inicializa el objeto dentro del Boton de Entrar
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();
                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conexion;

                /// Obtenemos la fecha del sistema
                DateTime Hoy = DateTime.Today;
                var hora = DateTime.Now.ToString("hh:mm:ss");
                string fecha_actual = Hoy.ToString("dd-MM-yyyy");


                /// Hacer Consulta para insertar los datos a la tabla de entrada
                /// 
                consulta.CommandText = ("INSERT INTO ENTRADA ( codigo, fecha, hora, status) VALUES ('" + txtCodigo.Text + "', '" + fecha_actual + "', '" + hora + "','1');");
                
                /// Si la consulta se ejecuta correctamente, se inserta el dato.
                /// 
                if (consulta.ExecuteNonQuery() == 1)
                {

                    txtCodigo.Clear(); /// Limpia lo que existe en el componente
                    txtCodigo.Focus(); /// Mantiene el Foco del cursos en el componente                   
                    
                }
                else
                {
                    MessageBox.Show("Dato No insertado");
                }

                string query = ("SELECT (400 - COUNT(*)) AS ESPACIOS FROM ENTRADA WHERE STATUS = 1;");
                MySqlCommand mycomand = new MySqlCommand(query, conexion);
                MySqlDataReader espacios = mycomand.ExecuteReader();

                if (espacios.Read())
                {
                    lblEntrada.Text = espacios["ESPACIOS"].ToString() + " DISPONIBLES";
                }

                conexion.Close();
                
            }
        }
    }
}
