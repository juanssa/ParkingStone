namespace SystemParking
{
    partial class frmAccesoEstudiante
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
            this.txtCodigoAcceso = new System.Windows.Forms.TextBox();
            this.cmbIdentificacionAcceso = new System.Windows.Forms.ComboBox();
            this.btnAcessoEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aqui se registra al estudiante que no tenga la credencial de la escuela, para pod" +
    "er registrarlo debe dejar una identificacion oficial.";
            // 
            // txtCodigoAcceso
            // 
            this.txtCodigoAcceso.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAcceso.Location = new System.Drawing.Point(17, 93);
            this.txtCodigoAcceso.Name = "txtCodigoAcceso";
            this.txtCodigoAcceso.Size = new System.Drawing.Size(327, 36);
            this.txtCodigoAcceso.TabIndex = 1;
            this.txtCodigoAcceso.Text = "Codigo";
            // 
            // cmbIdentificacionAcceso
            // 
            this.cmbIdentificacionAcceso.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdentificacionAcceso.FormattingEnabled = true;
            this.cmbIdentificacionAcceso.Items.AddRange(new object[] {
            "INE",
            "CEDULA",
            "PASAPORTE",
            "OTRA"});
            this.cmbIdentificacionAcceso.Location = new System.Drawing.Point(17, 155);
            this.cmbIdentificacionAcceso.Name = "cmbIdentificacionAcceso";
            this.cmbIdentificacionAcceso.Size = new System.Drawing.Size(327, 36);
            this.cmbIdentificacionAcceso.TabIndex = 2;
            // 
            // btnAcessoEstudiante
            // 
            this.btnAcessoEstudiante.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAcessoEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessoEstudiante.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessoEstudiante.Location = new System.Drawing.Point(17, 215);
            this.btnAcessoEstudiante.Name = "btnAcessoEstudiante";
            this.btnAcessoEstudiante.Size = new System.Drawing.Size(327, 38);
            this.btnAcessoEstudiante.TabIndex = 3;
            this.btnAcessoEstudiante.Text = "REGISTRAR";
            this.btnAcessoEstudiante.UseVisualStyleBackColor = false;
            // 
            // frmAccesoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcessoEstudiante);
            this.Controls.Add(this.cmbIdentificacionAcceso);
            this.Controls.Add(this.txtCodigoAcceso);
            this.Controls.Add(this.label1);
            this.Name = "frmAccesoEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCESO ESTUDIANTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoAcceso;
        private System.Windows.Forms.ComboBox cmbIdentificacionAcceso;
        private System.Windows.Forms.Button btnAcessoEstudiante;
    }
}