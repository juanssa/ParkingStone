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
    public partial class frmAccesoVisita : Form
    {
        public frmAccesoVisita()
        {
            InitializeComponent();
        }

        private void btnRegistrarVisita_Click(object sender, EventArgs e)
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

            consulta.CommandText = ("INSERT INTO VISITANTE( nombre_visita, compania, identificacion, placas, fecha, hora) VALUES ('" + txtNombreVisitante.Text + "', '" + txtCompañia.Text + "', '" + cmbIdentificacionVisitante.Text + "', '" + txtPlacas.Text + "','"+fecha_actual+"', '"+hora+"');");

            if (consulta.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Insertado");

                /// Restablece los placeholders de los campos de visitante.
                /// 
                txtNombreVisitante.Text = "NOMBRE VISITANTE";
                txtNombreVisitante.ForeColor = Color.Silver;
                txtCompañia.Text = "COMPAÑIA";
                txtCompañia.ForeColor = Color.Silver;
                cmbIdentificacionVisitante.Text = "IDENTIFICACION";
                cmbIdentificacionVisitante.ForeColor = Color.Silver;
                txtPlacas.Text = "PLACAS";
                txtPlacas.ForeColor = Color.Silver;

            }
            else
            {
                MessageBox.Show("Dato No insertado");
            }

            conexion.Close();
        }

        private void txtNombreVisitante_Enter(object sender, EventArgs e)
        {
            if (txtNombreVisitante.Text == "NOMBRE VISITANTE")
            {
                txtNombreVisitante.Text = "";

                txtNombreVisitante.ForeColor = Color.Black;
            }
        }

        private void txtNombreVisitante_Leave(object sender, EventArgs e)
        {
            if (txtNombreVisitante.Text == "")
            {
                txtNombreVisitante.Text = "NOMBRE VISITANTE";

                txtNombreVisitante.ForeColor = Color.Silver;
            }
        }

        private void txtCompañia_Enter(object sender, EventArgs e)
        {
            if (txtCompañia.Text == "COMPAÑIA")
            {
                txtCompañia.Text = "";

                txtCompañia.ForeColor = Color.Black;
            }
        }

        private void txtCompañia_Leave(object sender, EventArgs e)
        {
            if (txtCompañia.Text == "")
            {
                txtCompañia.Text = "COMPAÑIA";

                txtCompañia.ForeColor = Color.Silver;
            }
        }

        private void txtPlacas_Enter(object sender, EventArgs e)
        {
            if (txtPlacas.Text == "PLACAS")
            {
                txtPlacas.Text = "";

                txtPlacas.ForeColor = Color.Black;
            }
        }

        private void txtPlacas_Leave(object sender, EventArgs e)
        {
            if (txtPlacas.Text == "")
            {
                txtPlacas.Text = "PLACAS";

                txtPlacas.ForeColor = Color.Silver;
            }
        }

        private void cmbIdentificacionVisitante_Enter(object sender, EventArgs e)
        {
            if(cmbIdentificacionVisitante.Text == "IDENTIFICACION")
            {
                cmbIdentificacionVisitante.Text = "";

                cmbIdentificacionVisitante.ForeColor = Color.Black;
            }
        }

        private void cmbIdentificacionVisitante_Leave(object sender, EventArgs e)
        {
            if (cmbIdentificacionVisitante.Text == "")
            {
                cmbIdentificacionVisitante.Text = "IDENTIFICACION";

                cmbIdentificacionVisitante.ForeColor = Color.Silver;
            }
        }

        private void cmbIdentificacionVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
