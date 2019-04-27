namespace SystemParking
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSesion = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuBtnEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnVisitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuBtnIngreso = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnReportes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 139);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSesion.Location = new System.Drawing.Point(864, 65);
            this.lblSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(90, 29);
            this.lblSesion.TabIndex = 2;
            this.lblSesion.Text = "STAFF";
            this.lblSesion.Click += new System.EventHandler(this.lblSesion_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(980, 39);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(83, 76);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.ptbCerrarSession_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemParking.Properties.Resources.emovil;
            this.pictureBox1.Location = new System.Drawing.Point(357, 272);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuBtnEstudiantes
            // 
            this.MenuBtnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtnEstudiantes.Image")));
            this.MenuBtnEstudiantes.Name = "MenuBtnEstudiantes";
            this.MenuBtnEstudiantes.Size = new System.Drawing.Size(135, 24);
            this.MenuBtnEstudiantes.Text = "ESTUDIANTES";
            this.MenuBtnEstudiantes.Click += new System.EventHandler(this.MenuBtnEstudiantes_Click);
            // 
            // MenuBtnVisitantes
            // 
            this.MenuBtnVisitantes.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtnVisitantes.Image")));
            this.MenuBtnVisitantes.Name = "MenuBtnVisitantes";
            this.MenuBtnVisitantes.Size = new System.Drawing.Size(118, 24);
            this.MenuBtnVisitantes.Text = "VISITANTES";
            this.MenuBtnVisitantes.Click += new System.EventHandler(this.MenuBtnVisitantes_Click);
            // 
            // MenuBtnGraficos
            // 
            this.MenuBtnGraficos.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtnGraficos.Image")));
            this.MenuBtnGraficos.Name = "MenuBtnGraficos";
            this.MenuBtnGraficos.Size = new System.Drawing.Size(109, 24);
            this.MenuBtnGraficos.Text = "GRAFICOS";
            this.MenuBtnGraficos.Click += new System.EventHandler(this.MenuBtnGraficos_Click);
            // 
            // MenuBtnAyuda
            // 
            this.MenuBtnAyuda.Image = global::SystemParking.Properties.Resources.help;
            this.MenuBtnAyuda.Name = "MenuBtnAyuda";
            this.MenuBtnAyuda.Size = new System.Drawing.Size(68, 24);
            this.MenuBtnAyuda.Text = "FAQ";
            this.MenuBtnAyuda.Click += new System.EventHandler(this.MenuBtnAyuda_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.IndianRed;
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnIngreso,
            this.MenuBtnSalida,
            this.MenuBtnGraficos,
            this.MenuBtnReportes,
            this.MenuBtnEstudiantes,
            this.MenuBtnVisitantes,
            this.MenuBtnAyuda});
            this.menuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1079, 28);
            this.menuPrincipal.Stretch = false;
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // MenuBtnIngreso
            // 
            this.MenuBtnIngreso.Image = global::SystemParking.Properties.Resources.Student;
            this.MenuBtnIngreso.Name = "MenuBtnIngreso";
            this.MenuBtnIngreso.Size = new System.Drawing.Size(102, 24);
            this.MenuBtnIngreso.Text = "INGRESO";
            this.MenuBtnIngreso.Click += new System.EventHandler(this.MenuBtnIngreso_Click);
            // 
            // MenuBtnSalida
            // 
            this.MenuBtnSalida.Image = global::SystemParking.Properties.Resources.Unavailable;
            this.MenuBtnSalida.Name = "MenuBtnSalida";
            this.MenuBtnSalida.Size = new System.Drawing.Size(91, 24);
            this.MenuBtnSalida.Text = "SALIDA";
            this.MenuBtnSalida.Click += new System.EventHandler(this.MenuBtnSalida_Click);
            // 
            // MenuBtnReportes
            // 
            this.MenuBtnReportes.Image = global::SystemParking.Properties.Resources.staff;
            this.MenuBtnReportes.Name = "MenuBtnReportes";
            this.MenuBtnReportes.Size = new System.Drawing.Size(109, 24);
            this.MenuBtnReportes.Text = "REPORTES";
            this.MenuBtnReportes.Click += new System.EventHandler(this.MenuBtnReportes_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1079, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de estacionamientos";
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnVisitantes;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnGraficos;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnAyuda;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnReportes;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnIngreso;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnSalida;
    }
}