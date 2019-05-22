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
    public partial class frmListaSalida : Form
    {
        public frmListaSalida()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text.ToString() == "")
            {
                MessageBox.Show("Debe ingresar un codigo", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tablaSalidas.DataSource = null;

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from salida where codigo = '"+ txtCodigo.Text.ToString() +"'order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            tablaSalidas.DataSource = ds.Tables[0];

            conexion.Close();
            MessageBox.Show("Tabla actualizada", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            tablaSalidas.DataSource = null;

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from salida order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            tablaSalidas.DataSource = ds.Tables[0];

            conexion.Close();
            MessageBox.Show("Tabla actualizada", "Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
