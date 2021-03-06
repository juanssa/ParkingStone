﻿namespace SystemParking
{
    partial class frmEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelSemana = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.graficoSemanal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoDia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graficoSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelInicio.Location = new System.Drawing.Point(5, 9);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(768, 24);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = "Se muestra los graficos de la ultima semana y del dia pico apartir de hoy:   ";
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelSemana.Location = new System.Drawing.Point(12, 142);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(124, 29);
            this.labelSemana.TabIndex = 3;
            this.labelSemana.Text = "Semana: ";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelDia.Location = new System.Drawing.Point(555, 142);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(68, 29);
            this.labelDia.TabIndex = 4;
            this.labelDia.Text = "Dia: ";
            // 
            // graficoSemanal
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoSemanal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoSemanal.Legends.Add(legend1);
            this.graficoSemanal.Location = new System.Drawing.Point(17, 170);
            this.graficoSemanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graficoSemanal.Name = "graficoSemanal";
            this.graficoSemanal.Size = new System.Drawing.Size(521, 546);
            this.graficoSemanal.TabIndex = 5;
            this.graficoSemanal.Text = "chart1";
            // 
            // graficoDia
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoDia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoDia.Legends.Add(legend2);
            this.graficoDia.Location = new System.Drawing.Point(560, 170);
            this.graficoDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graficoDia.Name = "graficoDia";
            this.graficoDia.Size = new System.Drawing.Size(571, 546);
            this.graficoDia.TabIndex = 6;
            this.graficoDia.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recomendamos, para evitar la larga espera de un lugar, no usar\r\ntu coche el dia c" +
    "on mayor incidencia de registros o almenos evitar\r\nel horario pico.";
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1154, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graficoDia);
            this.Controls.Add(this.graficoSemanal);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.labelSemana);
            this.Controls.Add(this.labelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos descriptivos del numero de entradas";
            ((System.ComponentModel.ISupportInitialize)(this.graficoSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoSemanal;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoDia;
        private System.Windows.Forms.Label label1;
    }
}