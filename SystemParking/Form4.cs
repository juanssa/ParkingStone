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
    public partial class frmAccesoEstudiante : Form
    {
        public frmAccesoEstudiante()
        {
            InitializeComponent();
        }

        private void btnAcessoEstudiante_Click(object sender, EventArgs e)
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

            consulta.CommandText = ("INSERT INTO ACCESO_ESTUDIANTE ( codigo, fecha, hora, identificacion) VALUES ('" + txtCodigoAcceso.Text + "', '" + fecha_actual + "', '" + hora + "', '" + cmbIdentificacionAcceso.Text + "');");

            if (consulta.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Insertado");

            }
            else
            {
                MessageBox.Show("Dato No insertado");
            }

            conexion.Close();
        }

        private void txtCodigoAcceso_Enter(object sender, EventArgs e)
        {
            if(txtCodigoAcceso.Text == "CODIGO")
            {
                txtCodigoAcceso.Text = "";

                txtCodigoAcceso.ForeColor = Color.Black;
            }
        }

        private void txtCodigoAcceso_Leave(object sender, EventArgs e)
        {
            if (txtCodigoAcceso.Text == "")
            {
                txtCodigoAcceso.Text = "CODIGO";

                txtCodigoAcceso.ForeColor = Color.Silver;
            }
        }

        private void cmbIdentificacionAcceso_Enter(object sender, EventArgs e)
        {
            if( cmbIdentificacionAcceso.Text == "IDENTIFICACION")
            {
                cmbIdentificacionAcceso.Text = "";

                cmbIdentificacionAcceso.ForeColor = Color.Black;
            }
        }

        private void cmbIdentificacionAcceso_Leave(object sender, EventArgs e)
        {
            if (cmbIdentificacionAcceso.Text == "")
            {
                cmbIdentificacionAcceso.Text = "IDENTIFICACION";

                cmbIdentificacionAcceso.ForeColor = Color.Silver;
            }
        }
    }
}
