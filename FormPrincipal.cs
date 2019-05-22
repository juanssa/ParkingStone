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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            abrirFormHija(new FormInicio());
        }
         //Boton de lista de entradas en el menu inicial
        private void MenuBtnEntradas_Click(object sender, EventArgs e)
        {
            frmListaEntrada objetoLista = new frmListaEntrada();
            abrirFormHija(objetoLista);

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from entrada order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoLista.tablaEntradas.DataSource = ds.Tables[0];

            conexion.Close();
        }
        //boton de lista de salidas en el menu inicial

        private void MenuBtnSalidas_Click(object sender, EventArgs e)
        {
            frmListaSalida objetoLista = new frmListaSalida();
            abrirFormHija(objetoLista);

            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("Select * from salida order by id desc", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoLista.tablaSalidas.DataSource = ds.Tables[0];

            conexion.Close();
        }

        //Boton de graficos
        private void MenuBtnGraficos_Click(object sender, EventArgs e)
        {
            abrirFormHija(new frmEstadisticas());
        }

        //bton para abrir el form de ingreso
        private void MenuBtnIngreso_Click(object sender, EventArgs e)
        {
            abrirFormHija(new frmIngreso());
        }

        //btn para abrir el form de salidas
        private void MenuBtnSalida_Click(object sender, EventArgs e)
        {
            abrirFormHija(new frmSalida());
        }

        //btn para abrir el form de ayuda
        private void MenuBtnAyuda_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormAyuda());
        }


        private void MenuBtnReportes_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormReportes());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //codigo para mover mi aplicacion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //

        private void abrirFormHija(object formHija)
        {
            if (panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
                Form fh = formHija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(fh);
                panelPrincipal.Tag = fh;
                fh.Show();
            }
            else
            {
                Form fh = formHija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(fh);
                panelPrincipal.Tag = fh;
                fh.Show();
            }

        }

        private void imgInicio_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormInicio());
        }

    }
}
