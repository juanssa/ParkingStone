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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
         //Boton de lista de estudiantes en el menu inicial
        private void MenuBtnEstudiantes_Click(object sender, EventArgs e)
        {
            frmListaAlumnos objetoListaAlumnos = new frmListaAlumnos();
            objetoListaAlumnos.Show();

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from entrada order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoListaAlumnos.dgvEstudiante.DataSource = ds.Tables[0];

            conexion.Close();
        }
        //boton de lista de visitantes en el menu inicial
        private void MenuBtnVisitantes_Click(object sender, EventArgs e)
        {
            frmListaVisitas objetoListaVisitas = new frmListaVisitas();
            objetoListaVisitas.Show();


            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("SELECT * FROM VISITANTE ORDER BY ID DESC", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoListaVisitas.dgvVisitas.DataSource = ds.Tables[0];

            conexion.Close();
        }


        public void lblSesion_Click(object sender, EventArgs e)
        {
            frmLogin objetoLogin = new frmLogin();

            //user = objetoLogin.usuario;

            //lblSesion.Text = user;
            DialogResult res = objetoLogin.ShowDialog();

            if (res == DialogResult.OK)
            {
                lblSesion.Text = "Staff";
                //lblSesion.Text = objetoLogin.usuario.ToString();
            }
            lblSesion.Text = "Staff";
        }

        //Boton de graficos
        private void MenuBtnGraficos_Click(object sender, EventArgs e)
        {
            frmEstadisticas objetoEstadistica = new frmEstadisticas();
            objetoEstadistica.Show();
        }

        //bton para abrir el form de ingreso
        private void MenuBtnIngreso_Click(object sender, EventArgs e)
        {
            frmIngreso objetoAcceso = new frmIngreso();
            objetoAcceso.Show();
        }

        //btn para abrir el form de salidas
        private void MenuBtnSalida_Click(object sender, EventArgs e)
        {
            frmSalida objetoSalida = new frmSalida();
            objetoSalida.Show();
        }

        //btn para abrir el form de ayuda
        private void MenuBtnAyuda_Click(object sender, EventArgs e)
        {
            FormAyuda form = new FormAyuda();
            form.Show();
        }

        private void ptbCerrarSession_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesion. . .", "Exit");
            this.Close();
        }

        private void MenuBtnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }
    }
}
