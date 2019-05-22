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
    public partial class frmListaEntrada : Form
    {
        public frmListaEntrada()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.ToString() == "" && txtPlacas.Text.ToString() ==  "")
            {
                MessageBox.Show("Debe ingresar un codigo o placas de vehículo", "Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tablaEntradas.DataSource = null;

            if (txtCodigo.Text.ToString() == "")
            {
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();

                MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from entrada where placas = '" + txtPlacas.Text.ToString() + "'order by id desc", conexion);
                DataSet ds = new DataSet();
                dgv.Fill(ds);

                tablaEntradas.DataSource = ds.Tables[0];

                conexion.Close();
                MessageBox.Show("Tabla actualizada", "Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtPlacas.Text.ToString() == "")
            {
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();

                MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from entrada where codigo = '" + txtCodigo.Text.ToString() + "'order by id desc", conexion);
                DataSet ds = new DataSet();
                dgv.Fill(ds);

                tablaEntradas.DataSource = ds.Tables[0];

                conexion.Close();
                MessageBox.Show("Tabla actualizada", "Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            tablaEntradas.DataSource = null;

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from entrada order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            tablaEntradas.DataSource = ds.Tables[0];

            conexion.Close();
            MessageBox.Show("Tabla actualizada", "Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
