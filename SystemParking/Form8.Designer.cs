namespace SystemParking
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTAFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOSTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vISITORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARVISITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTADISTICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbCerrarSession = new System.Windows.Forms.PictureBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSession)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.sTAFFToolStripMenuItem,
            this.sTUDENTSToolStripMenuItem,
            this.vISITORSToolStripMenuItem,
            this.eSTADISTICAToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // sTAFFToolStripMenuItem
            // 
            this.sTAFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem,
            this.mOSTRARToolStripMenuItem});
            this.sTAFFToolStripMenuItem.Name = "sTAFFToolStripMenuItem";
            this.sTAFFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sTAFFToolStripMenuItem.Text = "STAFF";
            // 
            // aGREGARToolStripMenuItem
            // 
            this.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            this.aGREGARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aGREGARToolStripMenuItem.Text = "AGREGAR";
            this.aGREGARToolStripMenuItem.Click += new System.EventHandler(this.aGREGARToolStripMenuItem_Click);
            // 
            // mOSTRARToolStripMenuItem
            // 
            this.mOSTRARToolStripMenuItem.Name = "mOSTRARToolStripMenuItem";
            this.mOSTRARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mOSTRARToolStripMenuItem.Text = "MOSTRAR";
            this.mOSTRARToolStripMenuItem.Click += new System.EventHandler(this.mOSTRARToolStripMenuItem_Click);
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dARACCESOToolStripMenuItem,
            this.dARACCESSOToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sTUDENTSToolStripMenuItem.Text = "STUDENTS";
            // 
            // dARACCESOToolStripMenuItem
            // 
            this.dARACCESOToolStripMenuItem.Name = "dARACCESOToolStripMenuItem";
            this.dARACCESOToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dARACCESOToolStripMenuItem.Text = "INGRESO ";
            this.dARACCESOToolStripMenuItem.Click += new System.EventHandler(this.dARACCESOToolStripMenuItem_Click);
            // 
            // dARACCESSOToolStripMenuItem
            // 
            this.dARACCESSOToolStripMenuItem.Name = "dARACCESSOToolStripMenuItem";
            this.dARACCESSOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dARACCESSOToolStripMenuItem.Text = "DAR ACCESSO";
            this.dARACCESSOToolStripMenuItem.Click += new System.EventHandler(this.dARACCESSOToolStripMenuItem_Click);
            // 
            // vISITORSToolStripMenuItem
            // 
            this.vISITORSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dARACCESOToolStripMenuItem1,
            this.lISTARVISITARToolStripMenuItem});
            this.vISITORSToolStripMenuItem.Name = "vISITORSToolStripMenuItem";
            this.vISITORSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.vISITORSToolStripMenuItem.Text = "VISITORS";
            // 
            // dARACCESOToolStripMenuItem1
            // 
            this.dARACCESOToolStripMenuItem1.Name = "dARACCESOToolStripMenuItem1";
            this.dARACCESOToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dARACCESOToolStripMenuItem1.Text = "DAR ACCESO";
            this.dARACCESOToolStripMenuItem1.Click += new System.EventHandler(this.dARACCESOToolStripMenuItem1_Click);
            // 
            // lISTARVISITARToolStripMenuItem
            // 
            this.lISTARVISITARToolStripMenuItem.Name = "lISTARVISITARToolStripMenuItem";
            this.lISTARVISITARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lISTARVISITARToolStripMenuItem.Text = "LISTAR VISITAS";
            this.lISTARVISITARToolStripMenuItem.Click += new System.EventHandler(this.lISTARVISITARToolStripMenuItem_Click);
            // 
            // eSTADISTICAToolStripMenuItem
            // 
            this.eSTADISTICAToolStripMenuItem.Name = "eSTADISTICAToolStripMenuItem";
            this.eSTADISTICAToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.eSTADISTICAToolStripMenuItem.Text = "ESTADISTICA";
            this.eSTADISTICAToolStripMenuItem.Click += new System.EventHandler(this.eSTADISTICAToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // ptbCerrarSession
            // 
            this.ptbCerrarSession.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrarSession.Image")));
            this.ptbCerrarSession.Location = new System.Drawing.Point(683, 88);
            this.ptbCerrarSession.Name = "ptbCerrarSession";
            this.ptbCerrarSession.Size = new System.Drawing.Size(62, 62);
            this.ptbCerrarSession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCerrarSession.TabIndex = 6;
            this.ptbCerrarSession.TabStop = false;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSesion.Location = new System.Drawing.Point(598, 88);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(65, 24);
            this.lblSesion.TabIndex = 5;
            this.lblSesion.Text = "Admin";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al sistema de estacionamiento de estudiantes, esta herramienta permite" +
    " un control de los accesos de estudiantes y visitantes para mejorar el servicio " +
    "y dar mas rapidez.";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbCerrarSession);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARACCESOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARACCESSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vISITORSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARACCESOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lISTARVISITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTADISTICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOSTRARToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbCerrarSession;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.Label label1;
    }
}