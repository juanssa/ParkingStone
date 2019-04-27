using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemParking
{
    public partial class frmListaVisitas : Form
    {
        public frmListaVisitas()
        {
            InitializeComponent();
        }

        private void dgvVisitar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvVisitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtBuscar_Visita_Enter(object sender, EventArgs e)
        {
            if (txtBuscar_Visita.Text == "BUSCAR VISITANTE")
            {
                txtBuscar_Visita.Text = "";

                txtBuscar_Visita.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Visita_Leave(object sender, EventArgs e)
        {
            if (txtBuscar_Visita.Text == "")
            {
                txtBuscar_Visita.Text = "BUSCAR VISITANTE";

                txtBuscar_Visita.ForeColor = Color.Silver;
            }
        }

        private void btnBuscarVisita_Click(object sender, EventArgs e)
        {

        }

        private void frmListaVisitas_Load(object sender, EventArgs e)
        {

        }
    }
}
