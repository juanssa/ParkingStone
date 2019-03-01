namespace SystemParking
{
    partial class frmAddEmpleado
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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNss = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnAddEmpleado = new System.Windows.Forms.Button();
            this.lbAddEmpleado = new System.Windows.Forms.ListBox();
            this.txtUserEmpleado = new System.Windows.Forms.TextBox();
            this.txtPassEmpleado = new System.Windows.Forms.TextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(32, 91);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(266, 36);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.Text = "Nombre Completo";
            // 
            // txtNss
            // 
            this.txtNss.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNss.Location = new System.Drawing.Point(32, 32);
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(266, 36);
            this.txtNss.TabIndex = 1;
            this.txtNss.Text = "Nss";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(32, 151);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(266, 36);
            this.dtpFechaIngreso.TabIndex = 2;
            // 
            // btnAddEmpleado
            // 
            this.btnAddEmpleado.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddEmpleado.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpleado.Location = new System.Drawing.Point(32, 398);
            this.btnAddEmpleado.Name = "btnAddEmpleado";
            this.btnAddEmpleado.Size = new System.Drawing.Size(266, 40);
            this.btnAddEmpleado.TabIndex = 3;
            this.btnAddEmpleado.Text = "Registrar";
            this.btnAddEmpleado.UseVisualStyleBackColor = false;
            this.btnAddEmpleado.Click += new System.EventHandler(this.btnAddEmpleado_Click);
            // 
            // lbAddEmpleado
            // 
            this.lbAddEmpleado.FormattingEnabled = true;
            this.lbAddEmpleado.Location = new System.Drawing.Point(375, 80);
            this.lbAddEmpleado.Name = "lbAddEmpleado";
            this.lbAddEmpleado.Size = new System.Drawing.Size(381, 264);
            this.lbAddEmpleado.TabIndex = 4;
            // 
            // txtUserEmpleado
            // 
            this.txtUserEmpleado.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmpleado.Location = new System.Drawing.Point(32, 275);
            this.txtUserEmpleado.Name = "txtUserEmpleado";
            this.txtUserEmpleado.Size = new System.Drawing.Size(266, 36);
            this.txtUserEmpleado.TabIndex = 5;
            this.txtUserEmpleado.Text = "Usuario";
            // 
            // txtPassEmpleado
            // 
            this.txtPassEmpleado.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassEmpleado.Location = new System.Drawing.Point(32, 334);
            this.txtPassEmpleado.Name = "txtPassEmpleado";
            this.txtPassEmpleado.Size = new System.Drawing.Size(266, 36);
            this.txtPassEmpleado.TabIndex = 6;
            this.txtPassEmpleado.Text = "Password";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "staff",
            "admin"});
            this.cmbPuesto.Location = new System.Drawing.Point(32, 215);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(266, 36);
            this.cmbPuesto.TabIndex = 7;
            this.cmbPuesto.Text = "ROL";
            // 
            // frmAddEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.txtPassEmpleado);
            this.Controls.Add(this.txtUserEmpleado);
            this.Controls.Add(this.lbAddEmpleado);
            this.Controls.Add(this.btnAddEmpleado);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtNss);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Name = "frmAddEmpleado";
            this.Text = "Agregar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnAddEmpleado;
        private System.Windows.Forms.TextBox txtUserEmpleado;
        private System.Windows.Forms.TextBox txtPassEmpleado;
        private System.Windows.Forms.ComboBox cmbPuesto;
        public System.Windows.Forms.ListBox lbAddEmpleado;
    }
}