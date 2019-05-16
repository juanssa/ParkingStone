namespace SystemParking
{
    partial class frmListaAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaAlumnos));
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnListaAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.grbFecha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(13, 182);
            this.dgvEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.Size = new System.Drawing.Size(1128, 544);
            this.dgvEstudiante.TabIndex = 0;
            // 
            // grbFecha
            // 
            this.grbFecha.Controls.Add(this.dateTimePicker2);
            this.grbFecha.Controls.Add(this.dateTimePicker1);
            this.grbFecha.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.grbFecha.Location = new System.Drawing.Point(55, 36);
            this.grbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Padding = new System.Windows.Forms.Padding(4);
            this.grbFecha.Size = new System.Drawing.Size(353, 123);
            this.grbFecha.TabIndex = 1;
            this.grbFecha.TabStop = false;
            this.grbFecha.Text = "Fecha";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(195, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 28);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(480, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(353, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(199, 55);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(127, 28);
            this.dateTimePicker4.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(27, 55);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(127, 28);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // btnListaAlumnos
            // 
            this.btnListaAlumnos.BackColor = System.Drawing.Color.Orange;
            this.btnListaAlumnos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListaAlumnos.FlatAppearance.BorderSize = 3;
            this.btnListaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaAlumnos.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnListaAlumnos.Location = new System.Drawing.Point(895, 70);
            this.btnListaAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaAlumnos.Name = "btnListaAlumnos";
            this.btnListaAlumnos.Size = new System.Drawing.Size(177, 46);
            this.btnListaAlumnos.TabIndex = 3;
            this.btnListaAlumnos.Text = "CONSULTAR";
            this.btnListaAlumnos.UseVisualStyleBackColor = false;
            // 
            // frmListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1154, 739);
            this.Controls.Add(this.btnListaAlumnos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.dgvEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmListaAlumnos";
            this.Text = "Registros de estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.grbFecha.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnListaAlumnos;
        public System.Windows.Forms.DataGridView dgvEstudiante;
    }
}