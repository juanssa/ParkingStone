using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace SystemParking
{
    public partial class frmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
          int nLeftRect,  // x-coordinate of upper-left corner 
          int nTopRect,  // y-coordinate of upper-left corner 
          int nRightRect, // x-coordinate of lower-right corner 
          int nBottomRect, // y-coordinate of lower-right corner 
          int nWidthEllipse, // height of ellipse 
          int nHeightEllipse // width of ellipse 
         );

        public frmLogin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           
          
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "usuario")
            {
                txtUser.Text = "";

                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "usuario";

                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "********")
            {
                txtPass.Text = "";

                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "********";

                txtPass.ForeColor = Color.Silver;
            }
        }
    }
}
