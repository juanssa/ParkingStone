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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaVisitas));
            this.dgvVisitas = new System.Windows.Forms.DataGridView();
            this.txtBuscar_Visita = new System.Windows.Forms.TextBox();
            this.btnBuscarVisita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitas
            // 
            this.dgvVisitas.AllowUserToDeleteRows = false;
            this.dgvVisitas.AllowUserToResizeColumns = false;
            this.dgvVisitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvVisitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitas.Location = new System.Drawing.Point(1, 148);
            this.dgvVisitas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVisitas.Name = "dgvVisitas";
            this.dgvVisitas.Size = new System.Drawing.Size(1064, 406);
            this.dgvVisitas.TabIndex = 1;
            this.dgvVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitar_CellContentClick);
            // 
            // txtBuscar_Visita
            // 
            this.txtBuscar_Visita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar_Visita.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBuscar_Visita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar_Visita.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar_Visita.Location = new System.Drawing.Point(16, 31);
            this.txtBuscar_Visita.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar_Visita.Name = "txtBuscar_Visita";
            this.txtBuscar_Visita.Size = new System.Drawing.Size(875, 34);
            this.txtBuscar_Visita.TabIndex = 2;
            this.txtBuscar_Visita.Text = "BUSCAR VISITANTE\r\n";
            this.txtBuscar_Visita.Enter += new System.EventHandler(this.txtBuscar_Visita_Enter);
            this.txtBuscar_Visita.Leave += new System.EventHandler(this.txtBuscar_Visita_Leave);
            // 
            // btnBuscarVisita
            // 
            this.btnBuscarVisita.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscarVisita.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarVisita.FlatAppearance.BorderSize = 3;
            this.btnBuscarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVisita.Location = new System.Drawing.Point(915, 26);
            this.btnBuscarVisita.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarVisita.Name = "btnBuscarVisita";
            this.btnBuscarVisita.Size = new System.Drawing.Size(120, 47);
            this.btnBuscarVisita.TabIndex = 3;
            this.btnBuscarVisita.Text = "Buscar";
            this.btnBuscarVisita.UseVisualStyleBackColor = false;
            this.btnBuscarVisita.Click += new System.EventHandler(this.btnBuscarVisita_Click);
            // 
            // frmListaVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBuscarVisita);
            this.Controls.Add(this.txtBuscar_Visita);
            this.Controls.Add(this.dgvVisitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmListaVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Visitas";
            this.Load += new System.EventHandler(this.frmListaVisitas_Load);
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