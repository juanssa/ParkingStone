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

                consulta.CommandText = ("INSERT INTO ENTRADA ( codigo, fecha, hora) VALUES ('" + txtCodigo.Text + "', '" + fecha_actual + "', '" + hora + "');");


               

                if (consulta.ExecuteNonQuery() == 1)
                {
                    
                        txtCodigo.Clear();
                        txtCodigo.Focus();

                    lblEntrada.Text = "Acceso";
                    System.Threading.Thread.Sleep(1000);
                    lblEntrada.Text = "Espacios disponibles";



                }
                else
                {
                    MessageBox.Show("Dato No insertado");
                }

               
                conexion.Close();
                
            }
        }
    }
}
