namespace SystemParking
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbUser = new System.Windows.Forms.PictureBox();
            this.ptbPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.globoAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.AcceptsTab = true;
            this.txtUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUser.Location = new System.Drawing.Point(445, 113);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(285, 34);
            this.txtUser.TabIndex = 0;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.AcceptsTab = true;
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPass.Location = new System.Drawing.Point(445, 193);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(281, 34);
            this.txtPass.TabIndex = 1;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Orange;
            this.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(445, 263);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Size = new System.Drawing.Size(285, 50);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "INICIAR SESION";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Control y Acceso del Estacionamiento Estudiantil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbUser
            // 
            this.ptbUser.BackColor = System.Drawing.Color.Transparent;
            this.ptbUser.Image = ((System.Drawing.Image)(resources.GetObject("ptbUser.Image")));
            this.ptbUser.Location = new System.Drawing.Point(389, 113);
            this.ptbUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ptbUser.Name = "ptbUser";
            this.ptbUser.Size = new System.Drawing.Size(51, 44);
            this.ptbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUser.TabIndex = 6;
            this.ptbUser.TabStop = false;
            // 
            // ptbPass
            // 
            this.ptbPass.BackColor = System.Drawing.Color.Transparent;
            this.ptbPass.Image = ((System.Drawing.Image)(resources.GetObject("ptbPass.Image")));
            this.ptbPass.Location = new System.Drawing.Point(389, 183);
            this.ptbPass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ptbPass.Name = "ptbPass";
            this.ptbPass.Size = new System.Drawing.Size(51, 44);
            this.ptbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPass.TabIndex = 5;
            this.ptbPass.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.ptbUser);
            this.Controls.Add(this.ptbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.ptbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbPass;
        private System.Windows.Forms.PictureBox ptbUser;
        private System.Windows.Forms.ToolTip globoAyuda;
    }
}

