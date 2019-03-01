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
    public partial class frmAddEmpleado : Form
    {
        public frmAddEmpleado()
        {
            InitializeComponent();
        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {
            /// Se inicializa el objeto dentro del Boton de Entrar
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexion;

            consulta.CommandText = ("INSERT INTO EMPLEADO ( nss, nombre, fecha_ingreso, puesto, user, pass) VALUES ('" + txtNss.Text + "','" + txtNombreEmpleado.Text + "','" + dtpFechaIngreso.Text + "','"+cmbPuesto.Text+"','"+txtUserEmpleado.Text+"', '"+txtPassEmpleado.Text+"');");


            if (consulta.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Insertado");

                lbAddEmpleado.Text = "Insertado Correctamente";
                lbAddEmpleado.Text = txtNss.Text;
                lbAddEmpleado.Text = txtNombreEmpleado.Text;
                lbAddEmpleado.Text = txtUserEmpleado.Text;
                lbAddEmpleado.Text = txtPassEmpleado.Text;

            }else
            {
                MessageBox.Show("Dato No insertado");
            }

            conexion.Close();
        }
    }
}
