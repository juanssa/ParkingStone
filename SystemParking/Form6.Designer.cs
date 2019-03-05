namespace SystemParking
{
    partial class frmListaVisitas
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
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.txtBuscar_Visita = new System.Windows.Forms.TextBox();
            this.btnBuscarVisita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.AllowUserToResizeColumns = false;
            this.dgvVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.Location = new System.Drawing.Point(1, 120);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.Size = new System.Drawing.Size(798, 330);
            this.dgvVisitas.TabIndex = 1;
            this.dgvVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitar_CellContentClick);
            // 
            // txtBuscar_Visita
            // 
            this.txtBuscar_Visita.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_Visita.Location = new System.Drawing.Point(12, 25);
            this.txtBuscar_Visita.Name = "txtBuscar_Visita";
            this.txtBuscar_Visita.Size = new System.Drawing.Size(657, 36);
            this.txtBuscar_Visita.TabIndex = 2;
            this.txtBuscar_Visita.Text = "Busca por cualquier atributo";
            // 
            // btnBuscarVisita
            // 
            this.btnBuscarVisita.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVisita.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVisita.Location = new System.Drawing.Point(710, 25);
            this.btnBuscarVisita.Name = "btnBuscarVisita";
            this.btnBuscarVisita.Size = new System.Drawing.Size(78, 38);
            this.btnBuscarVisita.TabIndex = 3;
            this.btnBuscarVisita.Text = "Buscar";
            this.btnBuscarVisita.UseVisualStyleBackColor = false;
            // 
            // frmListaVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarVisita);
            this.Controls.Add(this.txtBuscar_Visita);
            this.Controls.Add(this.dgvVisitas);
            this.Name = "frmListaVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Visitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar_Visita;
        private System.Windows.Forms.Button btnBuscarVisita;
        public System.Windows.Forms.DataGridView dgvVisitas;
    }
}