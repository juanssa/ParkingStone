﻿namespace SystemParking
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAESTUDIANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vISITORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dARACCESOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARVISITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTADISTICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSesion = new System.Windows.Forms.Label();
            this.ptbCerrarSession = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSession)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.sTUDENTSToolStripMenuItem,
            this.vISITORSToolStripMenuItem,
            this.eSTADISTICAToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iNICIOToolStripMenuItem.Image")));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dARACCESOToolStripMenuItem,
            this.dARACCESSOToolStripMenuItem,
            this.sALIDAToolStripMenuItem,
            this.lISTAESTUDIANTEToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENTSToolStripMenuItem.Image")));
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.sTUDENTSToolStripMenuItem.Text = "STUDENTS";
            this.sTUDENTSToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTSToolStripMenuItem_Click);
            // 
            // dARACCESOToolStripMenuItem
            // 
            this.dARACCESOToolStripMenuItem.Name = "dARACCESOToolStripMenuItem";
            this.dARACCESOToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.dARACCESOToolStripMenuItem.Text = "INGRESO ";
            this.dARACCESOToolStripMenuItem.Click += new System.EventHandler(this.dARACCESOToolStripMenuItem_Click);
            // 
            // dARACCESSOToolStripMenuItem
            // 
            this.dARACCESSOToolStripMenuItem.Name = "dARACCESSOToolStripMenuItem";
            this.dARACCESSOToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.dARACCESSOToolStripMenuItem.Text = "DAR ACCESSO";
            this.dARACCESSOToolStripMenuItem.Click += new System.EventHandler(this.dARACCESSOToolStripMenuItem_Click);
            // 
            // sALIDAToolStripMenuItem
            // 
            this.sALIDAToolStripMenuItem.Name = "sALIDAToolStripMenuItem";
            this.sALIDAToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.sALIDAToolStripMenuItem.Text = "SALIDA";
            this.sALIDAToolStripMenuItem.Click += new System.EventHandler(this.sALIDAToolStripMenuItem_Click);
            // 
            // lISTAESTUDIANTEToolStripMenuItem
            // 
            this.lISTAESTUDIANTEToolStripMenuItem.Name = "lISTAESTUDIANTEToolStripMenuItem";
            this.lISTAESTUDIANTEToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.lISTAESTUDIANTEToolStripMenuItem.Text = "LISTA ESTUDIANTE";
            this.lISTAESTUDIANTEToolStripMenuItem.Click += new System.EventHandler(this.lISTAESTUDIANTEToolStripMenuItem_Click);
            // 
            // vISITORSToolStripMenuItem
            // 
            this.vISITORSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dARACCESOToolStripMenuItem1,
            this.lISTARVISITARToolStripMenuItem});
            this.vISITORSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vISITORSToolStripMenuItem.Image")));
            this.vISITORSToolStripMenuItem.Name = "vISITORSToolStripMenuItem";
            this.vISITORSToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.vISITORSToolStripMenuItem.Text = "VISITORS";
            // 
            // dARACCESOToolStripMenuItem1
            // 
            this.dARACCESOToolStripMenuItem1.Name = "dARACCESOToolStripMenuItem1";
            this.dARACCESOToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.dARACCESOToolStripMenuItem1.Text = "DAR ACCESO";
            this.dARACCESOToolStripMenuItem1.Click += new System.EventHandler(this.dARACCESOToolStripMenuItem1_Click);
            // 
            // lISTARVISITARToolStripMenuItem
            // 
            this.lISTARVISITARToolStripMenuItem.Name = "lISTARVISITARToolStripMenuItem";
            this.lISTARVISITARToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.lISTARVISITARToolStripMenuItem.Text = "LISTAR VISITAS";
            this.lISTARVISITARToolStripMenuItem.Click += new System.EventHandler(this.lISTARVISITARToolStripMenuItem_Click);
            // 
            // eSTADISTICAToolStripMenuItem
            // 
            this.eSTADISTICAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eSTADISTICAToolStripMenuItem.Image")));
            this.eSTADISTICAToolStripMenuItem.Name = "eSTADISTICAToolStripMenuItem";
            this.eSTADISTICAToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.eSTADISTICAToolStripMenuItem.Text = "ESTADISTICA";
            this.eSTADISTICAToolStripMenuItem.Click += new System.EventHandler(this.eSTADISTICAToolStripMenuItem_Click);
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.aYUDAToolStripMenuItem.Text = "AYUDA !";
            this.aYUDAToolStripMenuItem.Click += new System.EventHandler(this.aYUDAToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al sistema de estacionamiento de estudiantes, esta herramienta permite" +
    " un control de los accesos de estudiantes y visitantes para mejorar el servicio " +
    "y dar mas rapidez.";
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSesion.Location = new System.Drawing.Point(800, 63);
            this.lblSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(90, 29);
            this.lblSesion.TabIndex = 2;
            this.lblSesion.Text = "STAFF";
            this.lblSesion.Click += new System.EventHandler(this.lblSesion_Click);
            // 
            // ptbCerrarSession
            // 
            this.ptbCerrarSession.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrarSession.Image")));
            this.ptbCerrarSession.Location = new System.Drawing.Point(917, 63);
            this.ptbCerrarSession.Margin = new System.Windows.Forms.Padding(4);
            this.ptbCerrarSession.Name = "ptbCerrarSession";
            this.ptbCerrarSession.Size = new System.Drawing.Size(83, 76);
            this.ptbCerrarSession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCerrarSession.TabIndex = 3;
            this.ptbCerrarSession.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ptbCerrarSession);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
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
        private System.Windows.Forms.ToolStripMenuItem vISITORSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dARACCESOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lISTARVISITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSTADISTICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dARACCESSOToolStripMenuItem;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.PictureBox ptbCerrarSession;
        private System.Windows.Forms.ToolStripMenuItem sALIDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTAESTUDIANTEToolStripMenuItem;
    }
}