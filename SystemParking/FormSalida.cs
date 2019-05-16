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
    public partial class frmSalida : Form
    {
        public frmSalida()
        {
            InitializeComponent();
            globoAyuda.SetToolTip(txtCodigo,"Ingresa el codigo manualmente o mediante un escaner.");
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                //verificar existencia dentro del centro
                BDConect objetoV = new BDConect();
                MySqlConnection conexionV = objetoV.Conexion();
                MySqlCommand consultaV = new MySqlCommand();
                consultaV.Connection = conexionV;
                consultaV.CommandText = ("select count(*) from parkings where codigo = '" + txtCodigo.Text.ToString() + "'");
                int x = int.Parse(consultaV.ExecuteScalar().ToString());
                conexionV.Close();

                if(x > 0)
                {
                    //hacer consulta
                    /// Se inicializa el objeto dentro del Boton de Entrar
                    BDConect objeto = new BDConect();
                    MySqlConnection conexion = objeto.Conexion();
                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = conexion;

                    /// Obtenemos la fecha del sistema
                    DateTime Hoy = DateTime.Today;
                    var hora = DateTime.Now.ToString("hh:mm:ss");
                    string fecha_actual = Hoy.ToString("dd-MM-yyyy");

                    consulta.CommandText = ("INSERT INTO SALIDA ( codigo, fecha, hora) VALUES ('" + txtCodigo.Text + "', '" + fecha_actual + "', '" + hora + "');");

                    //int a = consulta.ExecuteNonQuery();

                    conexion.Close();

                    //Actualizar parking junto a salida
                    BDConect objeto2 = new BDConect();
                    MySqlConnection conexion2 = objeto2.Conexion();
                    MySqlCommand consulta2 = new MySqlCommand();
                    consulta2.Connection = conexion2;
                    consulta2.CommandText = ("update parkings set codigo = '' where codigo = '" + txtCodigo.Text.ToString() + "'");
                    int b = consulta2.ExecuteNonQuery();
                    conexion2.Close();

                    txtCodigo.Clear();

                    MessageBox.Show("Todo correcto, actualizando estacionamientos...", "Salida exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El codigo especificado no esta dentro\nde los registros del sistema.\n\nIntentalo nuevamente.", "Error en el codigo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            actualizarContador();

        }

        private void actualizarContador()
        {

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = ("select count(*) from parkings where codigo = ''");
            int lugares = int.Parse(consulta.ExecuteScalar().ToString());
            conexion.Close();

            string x = "Espacios disponibles: " + lugares.ToString();
            lblExit.Text = x;
        }

        private void frmSalida_Load(object sender, EventArgs e)
        {
            actualizarContador();
        }

    }
}