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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            globoAyuda.SetToolTip(txtCodigo, "Ingresa o escanea el codigo de la credencial de estudiante.");
            globoAyuda.SetToolTip(lblCodigo, "Ingresa o escanea el codigo de la credencial de estudiante.");
            globoAyuda.SetToolTip(txtParking, "Selecciona un estacionamiento de los disponibles abajo.");
            globoAyuda.SetToolTip(lblEspacio, "Selecciona un estacionamiento de los disponibles abajo.");
            globoAyuda.SetToolTip(btnIngreso, "Clic para ingresar la entrada en el sistema.");
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            actualizarContador();
            actualizarParkings();
        }

        private void parkingClick(object sender, EventArgs e)
        {
            Control btn = ((Control)sender);

            if(btn.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Ese lugar ya esta en uso, selecciona otro.", "Parking Lot");
                return;
            }
            else
            {
                if(txtCodigo.Text.ToString() != "")
                {
                    btnIngreso.BackColor = Color.FromArgb(199, 217, 163);
                }
            }
            txtParking.Text = btn.Text.ToString();
        }

        private void btnIngreso_click(object sender, EventArgs e)
        {
            //validar si hay los datos necesarios
            if(txtCodigo.Text.ToString() == "")
            {
                MessageBox.Show("Debe ingresar o escanear un codigo", "Parking Lot");
                return;
            }
            if (txtParking.Text.ToString() == "")
            {
                MessageBox.Show("Debe seleccionar un espacio", "Parking Lot");
                return;
            }
            //

            /// Se inicializa el objetor
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexion;

            /// Obtenemos la fecha del sistema
            DateTime Hoy = DateTime.Today;
            var hora = DateTime.Now.ToString("hh:mm:ss");
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");


            /// Hacer Consulta para insertar los datos a la tabla de entrada
            /// 
            consulta.CommandText = ("INSERT INTO ENTRADA ( codigo, fecha, hora, status) VALUES ('" + txtCodigo.Text + "', '" + fecha_actual + "', '" + hora + "','1');");

            /// Si la consulta se ejecuta correctamente, se inserta el dato.
            /// 
            if (consulta.ExecuteNonQuery() == 1)
            {               

            }
            else
            {
                MessageBox.Show("Dato No insertado");
            }
            conexion.Close();

            ///Actualizar lugar parking
            ///

            BDConect objeto2 = new BDConect();
            MySqlConnection conexion2 = objeto2.Conexion();
            MySqlCommand consulta2 = new MySqlCommand();
            consulta2.Connection = conexion2;
            consulta2.CommandText = ("update parkings set codigo = '" + txtCodigo.Text.ToString() +  "' where id = '" + txtParking.Text.ToString() + "'");
            int a = consulta2.ExecuteNonQuery();
            conexion2.Close();

            txtCodigo.Clear();
            txtParking.Clear();

            actualizarParkings();
            actualizarContador();
        }

        private void actualizarContador()
        {
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = ("select count(*) from parkings where codigo = ''");
            int lugares = int.Parse(consulta.ExecuteScalar().ToString());
            conexion.Close();

            string x = "Espacios disponibles: " + lugares.ToString();
            lblEntrada.Text = x;
        }

        private void actualizarParkings()
        {

            //evaluar los espacios
            BDConect objeto = new BDConect();
            MySqlConnection conexion = objeto.Conexion();
            MySqlCommand consulta = new MySqlCommand("select * from parkings", conexion);
            MySqlDataReader reader = consulta.ExecuteReader();
            string[,] parkings = new string[40, 3];

            int i = 0;
            while (reader.Read())
            {
                parkings[i, 0] = reader.GetValue(0).ToString();
                parkings[i, 1] = reader.GetValue(1).ToString();
                parkings[i, 2] = reader.GetValue(2).ToString();
                i++;
            }

            conexion.Close();

            //Cargamos los espacios al modulo
            for (i = 0; i < 40; i++)
            {

                string buscar = "park" + parkings[i, 0];
                if (parkings[i, 2] != "")
                {
                    this.Controls.Find(buscar, true)[0].BackColor = Color.IndianRed;
                    globoAyuda.SetToolTip(this.Controls.Find(buscar, true)[0], "Ocupado por: " + parkings[i, 2].ToString());
                }
                else
                {
                    if (parkings[i, 1] == "NORMAL")
                    {
                        this.Controls.Find(buscar, true)[0].BackColor = Color.FromArgb(193, 224, 156);
                        globoAyuda.SetToolTip(this.Controls.Find(buscar, true)[0], "Disponible - Estacionamiento normal.");
                    }

                    if (parkings[i, 1] == "DISCAPACIDAD")
                    {
                        this.Controls.Find(buscar, true)[0].BackColor = Color.FromArgb(133, 198, 199);
                        globoAyuda.SetToolTip(this.Controls.Find(buscar, true)[0], "Disponible - Estacionamiento para discapacitados.");
                    }

                    if (parkings[i, 1] == "VISITANTE")
                    {
                        this.Controls.Find(buscar, true)[0].BackColor = Color.FromArgb(220, 176, 84);
                        globoAyuda.SetToolTip(this.Controls.Find(buscar, true)[0], "Disponible - Estacionamiento para visitante.");
                    }

                    if (parkings[i, 1] == "PROVEEDOR")
                    {
                        this.Controls.Find(buscar, true)[0].BackColor = Color.FromArgb(235, 226, 111);
                        globoAyuda.SetToolTip(this.Controls.Find(buscar, true)[0], "Disponible - Estacionamiento para proveedor.");
                    }
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                txtCodigo.Text = txtCodigo.Text.ToString();
            }
        }
    }
}
