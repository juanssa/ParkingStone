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
            dgvVisitar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
