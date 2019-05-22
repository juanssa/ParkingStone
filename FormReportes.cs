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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            globoAyuda.SetToolTip(btnEliminar, "Elimina un registro seleccionado.");
            globoAyuda.SetToolTip(btnRefrescar, "Refresca la tabla de reportes.");
        }

        private void actualizarTabla()
        {
            DataSet ds = new DataSet();
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand("select * from reportes", conexion);
            MySqlDataAdapter mysqlA = new MySqlDataAdapter(consulta);

            mysqlA.Fill(ds);
            Tabla.DataSource = ds.Tables[0];
            conexion.Close();

            Tabla.Columns[0].Width = 100;
            Tabla.Columns[1].Width = 80;

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            actualizarTabla();

            Tabla.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Tabla.RowCount == 0 || Tabla.CurrentRow.Index < 0)
            {
                MessageBox.Show("Debes seleccionar una fila de reporte", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("¿Seguro que quieres eliminar este reporte?", "Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string query = "delete from reportes where descripcion = '" + Tabla.CurrentRow.Cells[1].Value.ToString() +"'";
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();
                MySqlCommand consulta = new MySqlCommand(query, conexion);
                MySqlDataReader reader;
                reader = consulta.ExecuteReader();
                conexion.Close();

                MessageBox.Show("Reporte eliminado", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarTabla();
            }
        }
    }
}
