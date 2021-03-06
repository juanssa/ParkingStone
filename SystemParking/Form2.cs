﻿using System;
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

        private void sTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dARACCESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreso objetoIngreso = new frmIngreso();
            objetoIngreso.Show();
        }

        private void dARACCESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccesoEstudiante objetoAcceso = new frmAccesoEstudiante();
            objetoAcceso.Show();
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


            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();

            MySqlDataAdapter dgv = new MySqlDataAdapter("SELECT * FROM VISITANTE ORDER BY ID DESC", conexion);
            DataSet ds = new DataSet();
            dgv.Fill(ds);

            objetoListaVisitas.dgvVisitas.DataSource = ds.Tables[0];

            conexion.Close();
        }


        public string user;
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

        private void eSTADISTICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticas objetoEstadistica = new frmEstadisticas();
            objetoEstadistica.Show();
        }

        private void sALIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalida objetoSalida = new frmSalida();
            objetoSalida.Show();
        }

        private void lISTAESTUDIANTEToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda form = new FormAyuda();
            form.Show();
        }
    }
}
