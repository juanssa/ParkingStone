namespace SystemParking
{
    partial class frmAccesoVisita
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreVisitante = new System.Windows.Forms.TextBox();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.cmbIdentificacionVisitante = new System.Windows.Forms.ComboBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.btnRegistrarVisita = new System.Windows.Forms.Button();
            this.ltbMensaje = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui se registran las visitas para poder ingresar al estacionamiento debe solicit" +
    "ar una identificacion oficial.";
            // 
            // txtNombreVisitante
            // 
            this.txtNombreVisitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreVisitante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombreVisitante.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVisitante.ForeColor = System.Drawing.Color.Silver;
            this.txtNombreVisitante.Location = new System.Drawing.Point(17, 80);
            this.txtNombreVisitante.Name = "txtNombreVisitante";
            this.txtNombreVisitante.Size = new System.Drawing.Size(308, 36);
            this.txtNombreVisitante.TabIndex = 1;
            this.txtNombreVisitante.Text = "NOMBRE VISITANTE";
            this.txtNombreVisitante.Enter += new System.EventHandler(this.txtNombreVisitante_Enter);
            this.txtNombreVisitante.Leave += new System.EventHandler(this.txtNombreVisitante_Leave);
            // 
            // txtCompañia
            // 
            this.txtCompañia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompañia.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompañia.ForeColor = System.Drawing.Color.Silver;
            this.txtCompañia.Location = new System.Drawing.Point(17, 142);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(308, 36);
            this.txtCompañia.TabIndex = 2;
            this.txtCompañia.Text = "COMPAÑIA";
            this.txtCompañia.Enter += new System.EventHandler(this.txtCompañia_Enter);
            this.txtCompañia.Leave += new System.EventHandler(this.txtCompañia_Leave);
            // 
            // cmbIdentificacionVisitante
            // 
            this.cmbIdentificacionVisitante.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdentificacionVisitante.ForeColor = System.Drawing.Color.Silver;
            this.cmbIdentificacionVisitante.Items.AddRange(new object[] {
            "Licencia",
            "INE",
            "Gafete Trabajo",
            "Pasaporte",
            "Cedula"});
            this.cmbIdentificacionVisitante.Location = new System.Drawing.Point(17, 203);
            this.cmbIdentificacionVisitante.Name = "cmbIdentificacionVisitante";
            this.cmbIdentificacionVisitante.Size = new System.Drawing.Size(148, 36);
            this.cmbIdentificacionVisitante.TabIndex = 3;
            this.cmbIdentificacionVisitante.Text = "IDENTIFICACION";
            this.cmbIdentificacionVisitante.Enter += new System.EventHandler(this.cmbIdentificacionVisitante_Enter);
            this.cmbIdentificacionVisitante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdentificacionVisitante_KeyPress);
            this.cmbIdentificacionVisitante.Leave += new System.EventHandler(this.cmbIdentificacionVisitante_Leave);
            // 
            // txtPlacas
            // 
            this.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacas.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.ForeColor = System.Drawing.Color.Silver;
            this.txtPlacas.Location = new System.Drawing.Point(17, 265);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(134, 36);
            this.txtPlacas.TabIndex = 4;
            this.txtPlacas.Text = "PLACAS";
            this.txtPlacas.Enter += new System.EventHandler(this.txtPlacas_Enter);
            this.txtPlacas.Leave += new System.EventHandler(this.txtPlacas_Leave);
            // 
            // btnRegistrarVisita
            // 
            this.btnRegistrarVisita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVisita.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVisita.Location = new System.Drawing.Point(17, 329);
            this.btnRegistrarVisita.Name = "btnRegistrarVisita";
            this.btnRegistrarVisita.Size = new System.Drawing.Size(134, 46);
            this.btnRegistrarVisita.TabIndex = 5;
            this.btnRegistrarVisita.Text = "REGISTRAR";
            this.btnRegistrarVisita.UseVisualStyleBackColor = false;
            this.btnRegistrarVisita.Click += new System.EventHandler(this.btnRegistrarVisita_Click);
            // 
            // ltbMensaje
            // 
            this.ltbMensaje.FormattingEnabled = true;
            this.ltbMensaje.Location = new System.Drawing.Point(437, 111);
            this.ltbMensaje.Name = "ltbMensaje";
            this.ltbMensaje.Size = new System.Drawing.Size(316, 264);
            this.ltbMensaje.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mensaje";
            // 
            // frmAccesoVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbMensaje);
            this.Controls.Add(this.btnRegistrarVisita);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.cmbIdentificacionVisitante);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.txtNombreVisitante);
            this.Controls.Add(this.label1);
            this.Name = "frmAccesoVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso Visita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreVisitante;
        private System.Windows.Forms.TextBox txtCompañia;
        private System.Windows.Forms.ComboBox cmbIdentificacionVisitante;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Button btnRegistrarVisita;
        private System.Windows.Forms.ListBox ltbMensaje;
        private System.Windows.Forms.Label label2;
    }
}