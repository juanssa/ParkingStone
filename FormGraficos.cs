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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace SystemParking
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
            inicializarForma();
        }

        private void inicializarForma()
        {
            //obtener fecha de hoy
            DateTime hoy = DateTime.Now;
            string fechaHoy = hoy.ToString("dd-MM-yyyy");
            string aux = labelInicio.Text;
            aux += " " + fechaHoy;
            labelInicio.Text = aux.ToString();

            //obtener ultimos 7 dias
            List<String> semana = new List<String>();

            for (int x = 7; x >= 1; x-- )
            {
                DateTime dia = hoy.AddDays(-x);
                semana.Add(dia.ToString("dd-MM-yyyy"));
            }
            //rellenar grafica semanal primero y despues del dia
            graficaDia(graficaSemanal(semana));
        }

        private string graficaSemanal(List<String> semana)
        {
            int i = 0, j = 0;

            string aux = labelSemana.Text.ToString();
            aux += " " + semana.ElementAt(0).ToString() + " al " + semana.ElementAt(6).ToString();
            labelSemana.Text = aux;

            List<int> nivel = new List<int>();

            for(int x = 0; x < semana.Count; x++)
            {
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();
                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conexion;
                consulta.CommandText = ("select count(*) from entrada where fecha = '" + semana.ElementAt(x).ToString() +"'");
                nivel.Add(int.Parse(consulta.ExecuteScalar().ToString()));
                conexion.Close();

            }

            graficoSemanal.Palette = ChartColorPalette.Pastel;
            graficoSemanal.Titles.Add("Semanal");

            for(int x = 0; x < semana.Count; x++)
            {
              
                Series serie = graficoSemanal.Series.Add(obtenerNombreDia(semana.ElementAt(x)) + " " + semana.ElementAt(x).ToString());
                serie.Label = nivel.ElementAt(x).ToString();
                serie.Points.Add(Convert.ToDouble(nivel.ElementAt(x)));

                //para retornar el numero en la lista, del dia que tiene mas coches
                if(i <= nivel.ElementAt(x))
                {
                    i = nivel.ElementAt(x);
                    j = x;
                }
            }

            return semana.ElementAt(j).ToString();

        }

        private void graficaDia(String fechaHoy)
        {
            string aux = labelDia.Text.ToString();
            aux += " " + obtenerNombreDia(fechaHoy) + " " + fechaHoy;
            labelDia.Text = aux;

            graficoDia.Palette = ChartColorPalette.Pastel;
            graficoDia.Titles.Add("Dia Pico");

            for (int x = 7; x <= 21; x++)
            {
                BDConect objeto = new BDConect();
                MySqlConnection conexion = objeto.Conexion();
                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conexion;

                if(x < 10)
                {
                    consulta.CommandText = ("select count(*) from entrada where hora LIKE '0" +  x.ToString() + "%'");
                }
                else
                {
                    consulta.CommandText = ("select count(*) from entrada where hora LIKE '" + x.ToString() + "%'");
                }

                int num = int.Parse(consulta.ExecuteScalar().ToString());

                Series serie = graficoDia.Series.Add(x.ToString() + " Hrs");
                serie.Label = num.ToString();
                serie.Points.Add(Convert.ToDouble(num));

                
                conexion.Close();

            }

        }

        private String obtenerNombreDia(String fecha)
        {
            DateTime myDate = DateTime.ParseExact(fecha, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            return myDate.ToString("dddd", new CultureInfo("es-ES"));
        }
    }
}
