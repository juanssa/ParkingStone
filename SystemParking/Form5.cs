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
    public partial class frmAccesoVisita : Form
    {
        public frmAccesoVisita()
        {
            InitializeComponent();
        }

        private void btnRegistrarVisita_Click(object sender, EventArgs e)
        {
            /// Se inicializa el objeto dentro del Boton de Entrar
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexion;


            /// Obtenemos la fecha del sistema
            DateTime Hoy = DateTime.Today;
            var hora = DateTime.Now.ToString("hh:mm:ss");
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");

            consulta.CommandText = ("INSERT INTO VISITANTE( nombre_visita, compania, identificacion, placas, fecha, hora) VALUES ('" + txtNombreVisitante.Text + "', '" + txtCompañia.Text + "', '" + cmbIdentificacionVisitante.Text + "', '" + txtPlacas.Text + "','"+fecha_actual+"', '"+hora+"');");

            if (consulta.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Dato Insertado");

            }
            else
            {
                MessageBox.Show("Dato No insertado");
            }

            conexion.Close();
        }
    }
}
