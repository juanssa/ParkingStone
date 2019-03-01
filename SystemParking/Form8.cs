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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void dARACCESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso objetoIngreso = new frmIngreso();
            objetoIngreso.Show();
        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEmpleado objetoAddEmpleado = new frmAddEmpleado();
            objetoAddEmpleado.Show();
        }

        private void mOSTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEmpleados objetoListaEmpleados = new frmListaEmpleados();
            objetoListaEmpleados.Show();

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from empleado", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoListaEmpleados.dgvEmpleados.DataSource = ds.Tables[0];
            
           

            conexion.Close();
        }

        private void dARACCESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccesoEstudiante objetoAccesoEstudiante = new frmAccesoEstudiante();
            objetoAccesoEstudiante.Show();
        }

        private void dARACCESOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAccesoVisita objetoAccesoVisita = new frmAccesoVisita();
            objetoAccesoVisita.Show();
        }

        private void lISTARVISITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaVisitas objetoListaVisitas = new frmListaVisitas();
            objetoListaVisitas.Show();

            
        }

        private void eSTADISTICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticas objetoEstadisticas = new frmEstadisticas();
            objetoEstadisticas.Show();
        }
    }
}
