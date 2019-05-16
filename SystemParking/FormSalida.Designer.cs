namespace SystemParking
{
    partial class frmSalida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalida));
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.globoAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblSalida
            // 
            this.lblSalida.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lblSalida.Location = new System.Drawing.Point(158, 70);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(856, 143);
            this.lblSalida.TabIndex = 2;
            this.lblSalida.Text = "Escanea el codigo de la credencial o\r\n ingresa manualmente el codigo.\r\n";
            this.lblSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(311, 289);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(539, 36);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(315, 396);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(525, 129);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "400 Espacios";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1154, 739);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblSalida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSalida";
            this.Text = "Salida de coches";
            this.Load += new System.EventHandler(this.frmSalida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ToolTip globoAyuda;
    }
}