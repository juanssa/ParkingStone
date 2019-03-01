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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string usuario;

        public void btnEntrar_Click(object sender, EventArgs e)
        {

            /// Se inicializa el objeto dentro del Boton de Entrar
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            MySqlCommand puesto = new MySqlCommand();

            consulta.Connection = conexion;
            



            consulta.CommandText = ("Select * from  usuario where user = '" + txtUser.Text + "' and pass  = '" + txtPass.Text + "' and puesto = 'staff' or puesto = 'admin';");
            

            MySqlDataReader leer = consulta.ExecuteReader();

            


            if (leer.Read()==true)
            {
                usuario = leer["puesto"].ToString();

                if (usuario == "staff")
                {
                    MessageBox.Show("Bienvenido...", usuario);
                    this.Hide();

                    frmInicio objetoInicio = new frmInicio();
                    objetoInicio.Show();

                }
                else if (usuario == "admin") {

                    MessageBox.Show("Bienvenido...", usuario);
                    this.Hide();

                    frmAdmin objetoAdmin = new frmAdmin();
                    objetoAdmin.Show();

                }
                

                
             
            }
            else {

                MessageBox.Show("User or Pass Incorrectos");
            }

            conexion.Close();


            

        }
    }
}
