﻿namespace SystemParking
{
    partial class frmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.parkD1 = new System.Windows.Forms.Button();
            this.parkC1 = new System.Windows.Forms.Button();
            this.parkB1 = new System.Windows.Forms.Button();
            this.parkA1 = new System.Windows.Forms.Button();
            this.parkA2 = new System.Windows.Forms.Button();
            this.parkB2 = new System.Windows.Forms.Button();
            this.parkC2 = new System.Windows.Forms.Button();
            this.parkD2 = new System.Windows.Forms.Button();
            this.parkA4 = new System.Windows.Forms.Button();
            this.parkB4 = new System.Windows.Forms.Button();
            this.parkC4 = new System.Windows.Forms.Button();
            this.parkD4 = new System.Windows.Forms.Button();
            this.parkA3 = new System.Windows.Forms.Button();
            this.parkB3 = new System.Windows.Forms.Button();
            this.parkC3 = new System.Windows.Forms.Button();
            this.parkD3 = new System.Windows.Forms.Button();
            this.parkA5 = new System.Windows.Forms.Button();
            this.parkB5 = new System.Windows.Forms.Button();
            this.parkC5 = new System.Windows.Forms.Button();
            this.parkD5 = new System.Windows.Forms.Button();
            this.parkA10 = new System.Windows.Forms.Button();
            this.parkB10 = new System.Windows.Forms.Button();
            this.parkC10 = new System.Windows.Forms.Button();
            this.parkD10 = new System.Windows.Forms.Button();
            this.parkA8 = new System.Windows.Forms.Button();
            this.parkB8 = new System.Windows.Forms.Button();
            this.parkC8 = new System.Windows.Forms.Button();
            this.parkD8 = new System.Windows.Forms.Button();
            this.parkA9 = new System.Windows.Forms.Button();
            this.parkB9 = new System.Windows.Forms.Button();
            this.parkC9 = new System.Windows.Forms.Button();
            this.parkD9 = new System.Windows.Forms.Button();
            this.parkA7 = new System.Windows.Forms.Button();
            this.parkB7 = new System.Windows.Forms.Button();
            this.parkC7 = new System.Windows.Forms.Button();
            this.parkD7 = new System.Windows.Forms.Button();
            this.parkA6 = new System.Windows.Forms.Button();
            this.parkB6 = new System.Windows.Forms.Button();
            this.parkC6 = new System.Windows.Forms.Button();
            this.parkD6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.txtParking = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.globoAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCodigo.Location = new System.Drawing.Point(47, 93);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 32);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCodigo.Location = new System.Drawing.Point(44, 57);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(179, 32);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrada
            // 
            this.lblEntrada.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblEntrada.ForeColor = System.Drawing.Color.Black;
            this.lblEntrada.Location = new System.Drawing.Point(602, 56);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(497, 78);
            this.lblEntrada.TabIndex = 2;
            this.lblEntrada.Text = "Espacios Disponibles: ";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parkD1
            // 
            this.parkD1.BackColor = System.Drawing.Color.Green;
            this.parkD1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD1.Location = new System.Drawing.Point(47, 605);
            this.parkD1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD1.Name = "parkD1";
            this.parkD1.Size = new System.Drawing.Size(100, 100);
            this.parkD1.TabIndex = 3;
            this.parkD1.Text = "D1";
            this.parkD1.UseVisualStyleBackColor = false;
            this.parkD1.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC1
            // 
            this.parkC1.BackColor = System.Drawing.Color.Green;
            this.parkC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC1.Location = new System.Drawing.Point(46, 499);
            this.parkC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC1.Name = "parkC1";
            this.parkC1.Size = new System.Drawing.Size(100, 100);
            this.parkC1.TabIndex = 5;
            this.parkC1.Text = "C1";
            this.parkC1.UseVisualStyleBackColor = false;
            this.parkC1.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB1
            // 
            this.parkB1.BackColor = System.Drawing.Color.Turquoise;
            this.parkB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB1.Location = new System.Drawing.Point(46, 280);
            this.parkB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB1.Name = "parkB1";
            this.parkB1.Size = new System.Drawing.Size(100, 100);
            this.parkB1.TabIndex = 6;
            this.parkB1.Text = "B1";
            this.parkB1.UseVisualStyleBackColor = false;
            this.parkB1.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA1
            // 
            this.parkA1.BackColor = System.Drawing.Color.Green;
            this.parkA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA1.Location = new System.Drawing.Point(46, 175);
            this.parkA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA1.Name = "parkA1";
            this.parkA1.Size = new System.Drawing.Size(100, 100);
            this.parkA1.TabIndex = 7;
            this.parkA1.Text = "A1";
            this.parkA1.UseVisualStyleBackColor = false;
            this.parkA1.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA2
            // 
            this.parkA2.BackColor = System.Drawing.Color.Green;
            this.parkA2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA2.Location = new System.Drawing.Point(151, 175);
            this.parkA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA2.Name = "parkA2";
            this.parkA2.Size = new System.Drawing.Size(100, 100);
            this.parkA2.TabIndex = 11;
            this.parkA2.Text = "A2";
            this.parkA2.UseVisualStyleBackColor = false;
            this.parkA2.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB2
            // 
            this.parkB2.BackColor = System.Drawing.Color.Turquoise;
            this.parkB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB2.Location = new System.Drawing.Point(151, 280);
            this.parkB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB2.Name = "parkB2";
            this.parkB2.Size = new System.Drawing.Size(100, 100);
            this.parkB2.TabIndex = 10;
            this.parkB2.Text = "B2";
            this.parkB2.UseVisualStyleBackColor = false;
            this.parkB2.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC2
            // 
            this.parkC2.BackColor = System.Drawing.Color.Green;
            this.parkC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC2.Location = new System.Drawing.Point(151, 499);
            this.parkC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC2.Name = "parkC2";
            this.parkC2.Size = new System.Drawing.Size(100, 100);
            this.parkC2.TabIndex = 9;
            this.parkC2.Text = "C2";
            this.parkC2.UseVisualStyleBackColor = false;
            this.parkC2.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD2
            // 
            this.parkD2.BackColor = System.Drawing.Color.Green;
            this.parkD2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD2.Location = new System.Drawing.Point(154, 605);
            this.parkD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD2.Name = "parkD2";
            this.parkD2.Size = new System.Drawing.Size(100, 100);
            this.parkD2.TabIndex = 8;
            this.parkD2.Text = "D2";
            this.parkD2.UseVisualStyleBackColor = false;
            this.parkD2.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA4
            // 
            this.parkA4.BackColor = System.Drawing.Color.Green;
            this.parkA4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA4.Location = new System.Drawing.Point(365, 175);
            this.parkA4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA4.Name = "parkA4";
            this.parkA4.Size = new System.Drawing.Size(100, 100);
            this.parkA4.TabIndex = 15;
            this.parkA4.Text = "A4";
            this.parkA4.UseVisualStyleBackColor = false;
            this.parkA4.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB4
            // 
            this.parkB4.BackColor = System.Drawing.Color.Turquoise;
            this.parkB4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB4.Location = new System.Drawing.Point(365, 280);
            this.parkB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB4.Name = "parkB4";
            this.parkB4.Size = new System.Drawing.Size(100, 100);
            this.parkB4.TabIndex = 14;
            this.parkB4.Text = "B4";
            this.parkB4.UseVisualStyleBackColor = false;
            this.parkB4.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC4
            // 
            this.parkC4.BackColor = System.Drawing.Color.Green;
            this.parkC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC4.Location = new System.Drawing.Point(365, 499);
            this.parkC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC4.Name = "parkC4";
            this.parkC4.Size = new System.Drawing.Size(100, 100);
            this.parkC4.TabIndex = 13;
            this.parkC4.Text = "C4";
            this.parkC4.UseVisualStyleBackColor = false;
            this.parkC4.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD4
            // 
            this.parkD4.BackColor = System.Drawing.Color.Green;
            this.parkD4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD4.Location = new System.Drawing.Point(366, 605);
            this.parkD4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD4.Name = "parkD4";
            this.parkD4.Size = new System.Drawing.Size(100, 100);
            this.parkD4.TabIndex = 12;
            this.parkD4.Text = "D4";
            this.parkD4.UseVisualStyleBackColor = false;
            this.parkD4.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA3
            // 
            this.parkA3.BackColor = System.Drawing.Color.Green;
            this.parkA3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA3.Location = new System.Drawing.Point(258, 175);
            this.parkA3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA3.Name = "parkA3";
            this.parkA3.Size = new System.Drawing.Size(100, 100);
            this.parkA3.TabIndex = 19;
            this.parkA3.Text = "A3";
            this.parkA3.UseVisualStyleBackColor = false;
            this.parkA3.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB3
            // 
            this.parkB3.BackColor = System.Drawing.Color.Turquoise;
            this.parkB3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB3.Location = new System.Drawing.Point(258, 280);
            this.parkB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB3.Name = "parkB3";
            this.parkB3.Size = new System.Drawing.Size(100, 100);
            this.parkB3.TabIndex = 18;
            this.parkB3.Text = "B3";
            this.parkB3.UseVisualStyleBackColor = false;
            this.parkB3.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC3
            // 
            this.parkC3.BackColor = System.Drawing.Color.Green;
            this.parkC3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC3.Location = new System.Drawing.Point(258, 499);
            this.parkC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC3.Name = "parkC3";
            this.parkC3.Size = new System.Drawing.Size(100, 100);
            this.parkC3.TabIndex = 17;
            this.parkC3.Text = "C3";
            this.parkC3.UseVisualStyleBackColor = false;
            this.parkC3.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD3
            // 
            this.parkD3.BackColor = System.Drawing.Color.Green;
            this.parkD3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD3.Location = new System.Drawing.Point(261, 605);
            this.parkD3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD3.Name = "parkD3";
            this.parkD3.Size = new System.Drawing.Size(100, 100);
            this.parkD3.TabIndex = 16;
            this.parkD3.Text = "D3";
            this.parkD3.UseVisualStyleBackColor = false;
            this.parkD3.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA5
            // 
            this.parkA5.BackColor = System.Drawing.Color.Green;
            this.parkA5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA5.Location = new System.Drawing.Point(470, 175);
            this.parkA5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA5.Name = "parkA5";
            this.parkA5.Size = new System.Drawing.Size(100, 100);
            this.parkA5.TabIndex = 23;
            this.parkA5.Text = "A5";
            this.parkA5.UseVisualStyleBackColor = false;
            this.parkA5.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB5
            // 
            this.parkB5.BackColor = System.Drawing.Color.Green;
            this.parkB5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB5.Location = new System.Drawing.Point(470, 280);
            this.parkB5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB5.Name = "parkB5";
            this.parkB5.Size = new System.Drawing.Size(100, 100);
            this.parkB5.TabIndex = 22;
            this.parkB5.Text = "B5";
            this.parkB5.UseVisualStyleBackColor = false;
            this.parkB5.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC5
            // 
            this.parkC5.BackColor = System.Drawing.Color.Green;
            this.parkC5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC5.Location = new System.Drawing.Point(470, 499);
            this.parkC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC5.Name = "parkC5";
            this.parkC5.Size = new System.Drawing.Size(100, 100);
            this.parkC5.TabIndex = 21;
            this.parkC5.Text = "C5";
            this.parkC5.UseVisualStyleBackColor = false;
            this.parkC5.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD5
            // 
            this.parkD5.BackColor = System.Drawing.Color.Green;
            this.parkD5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD5.Location = new System.Drawing.Point(471, 605);
            this.parkD5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD5.Name = "parkD5";
            this.parkD5.Size = new System.Drawing.Size(100, 100);
            this.parkD5.TabIndex = 20;
            this.parkD5.Text = "D5";
            this.parkD5.UseVisualStyleBackColor = false;
            this.parkD5.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA10
            // 
            this.parkA10.BackColor = System.Drawing.Color.Green;
            this.parkA10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA10.Location = new System.Drawing.Point(999, 175);
            this.parkA10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA10.Name = "parkA10";
            this.parkA10.Size = new System.Drawing.Size(100, 100);
            this.parkA10.TabIndex = 43;
            this.parkA10.Text = "A10";
            this.parkA10.UseVisualStyleBackColor = false;
            this.parkA10.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB10
            // 
            this.parkB10.BackColor = System.Drawing.Color.Green;
            this.parkB10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB10.Location = new System.Drawing.Point(999, 280);
            this.parkB10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB10.Name = "parkB10";
            this.parkB10.Size = new System.Drawing.Size(100, 100);
            this.parkB10.TabIndex = 42;
            this.parkB10.Text = "B10";
            this.parkB10.UseVisualStyleBackColor = false;
            this.parkB10.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC10
            // 
            this.parkC10.BackColor = System.Drawing.Color.Yellow;
            this.parkC10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC10.Location = new System.Drawing.Point(999, 499);
            this.parkC10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC10.Name = "parkC10";
            this.parkC10.Size = new System.Drawing.Size(100, 100);
            this.parkC10.TabIndex = 41;
            this.parkC10.Text = "C10";
            this.parkC10.UseVisualStyleBackColor = false;
            this.parkC10.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD10
            // 
            this.parkD10.BackColor = System.Drawing.Color.Green;
            this.parkD10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD10.Location = new System.Drawing.Point(1002, 605);
            this.parkD10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD10.Name = "parkD10";
            this.parkD10.Size = new System.Drawing.Size(100, 100);
            this.parkD10.TabIndex = 40;
            this.parkD10.Text = "D10";
            this.parkD10.UseVisualStyleBackColor = false;
            this.parkD10.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA8
            // 
            this.parkA8.BackColor = System.Drawing.Color.Green;
            this.parkA8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA8.Location = new System.Drawing.Point(789, 175);
            this.parkA8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA8.Name = "parkA8";
            this.parkA8.Size = new System.Drawing.Size(100, 100);
            this.parkA8.TabIndex = 39;
            this.parkA8.Text = "A8";
            this.parkA8.UseVisualStyleBackColor = false;
            this.parkA8.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB8
            // 
            this.parkB8.BackColor = System.Drawing.Color.Green;
            this.parkB8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB8.Location = new System.Drawing.Point(789, 280);
            this.parkB8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB8.Name = "parkB8";
            this.parkB8.Size = new System.Drawing.Size(100, 100);
            this.parkB8.TabIndex = 38;
            this.parkB8.Text = "B8";
            this.parkB8.UseVisualStyleBackColor = false;
            this.parkB8.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC8
            // 
            this.parkC8.BackColor = System.Drawing.Color.Green;
            this.parkC8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC8.Location = new System.Drawing.Point(789, 499);
            this.parkC8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC8.Name = "parkC8";
            this.parkC8.Size = new System.Drawing.Size(100, 100);
            this.parkC8.TabIndex = 37;
            this.parkC8.Text = "C8";
            this.parkC8.UseVisualStyleBackColor = false;
            this.parkC8.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD8
            // 
            this.parkD8.BackColor = System.Drawing.Color.Green;
            this.parkD8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD8.Location = new System.Drawing.Point(790, 605);
            this.parkD8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD8.Name = "parkD8";
            this.parkD8.Size = new System.Drawing.Size(100, 100);
            this.parkD8.TabIndex = 36;
            this.parkD8.Text = "D8";
            this.parkD8.UseVisualStyleBackColor = false;
            this.parkD8.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA9
            // 
            this.parkA9.BackColor = System.Drawing.Color.Green;
            this.parkA9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA9.Location = new System.Drawing.Point(894, 175);
            this.parkA9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA9.Name = "parkA9";
            this.parkA9.Size = new System.Drawing.Size(100, 100);
            this.parkA9.TabIndex = 35;
            this.parkA9.Text = "A9";
            this.parkA9.UseVisualStyleBackColor = false;
            this.parkA9.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB9
            // 
            this.parkB9.BackColor = System.Drawing.Color.Green;
            this.parkB9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB9.Location = new System.Drawing.Point(894, 280);
            this.parkB9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB9.Name = "parkB9";
            this.parkB9.Size = new System.Drawing.Size(100, 100);
            this.parkB9.TabIndex = 34;
            this.parkB9.Text = "B9";
            this.parkB9.UseVisualStyleBackColor = false;
            this.parkB9.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC9
            // 
            this.parkC9.BackColor = System.Drawing.Color.Orange;
            this.parkC9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC9.Location = new System.Drawing.Point(894, 499);
            this.parkC9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC9.Name = "parkC9";
            this.parkC9.Size = new System.Drawing.Size(100, 100);
            this.parkC9.TabIndex = 33;
            this.parkC9.Text = "C9";
            this.parkC9.UseVisualStyleBackColor = false;
            this.parkC9.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD9
            // 
            this.parkD9.BackColor = System.Drawing.Color.Green;
            this.parkD9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD9.Location = new System.Drawing.Point(895, 605);
            this.parkD9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD9.Name = "parkD9";
            this.parkD9.Size = new System.Drawing.Size(100, 100);
            this.parkD9.TabIndex = 32;
            this.parkD9.Text = "D9";
            this.parkD9.UseVisualStyleBackColor = false;
            this.parkD9.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA7
            // 
            this.parkA7.BackColor = System.Drawing.Color.Green;
            this.parkA7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA7.Location = new System.Drawing.Point(682, 175);
            this.parkA7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA7.Name = "parkA7";
            this.parkA7.Size = new System.Drawing.Size(100, 100);
            this.parkA7.TabIndex = 31;
            this.parkA7.Text = "A7";
            this.parkA7.UseVisualStyleBackColor = false;
            this.parkA7.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB7
            // 
            this.parkB7.BackColor = System.Drawing.Color.Green;
            this.parkB7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB7.Location = new System.Drawing.Point(682, 280);
            this.parkB7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB7.Name = "parkB7";
            this.parkB7.Size = new System.Drawing.Size(100, 100);
            this.parkB7.TabIndex = 30;
            this.parkB7.Text = "B7";
            this.parkB7.UseVisualStyleBackColor = false;
            this.parkB7.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC7
            // 
            this.parkC7.BackColor = System.Drawing.Color.Green;
            this.parkC7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC7.Location = new System.Drawing.Point(682, 499);
            this.parkC7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC7.Name = "parkC7";
            this.parkC7.Size = new System.Drawing.Size(100, 100);
            this.parkC7.TabIndex = 29;
            this.parkC7.Text = "C7";
            this.parkC7.UseVisualStyleBackColor = false;
            this.parkC7.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD7
            // 
            this.parkD7.BackColor = System.Drawing.Color.Green;
            this.parkD7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD7.Location = new System.Drawing.Point(685, 605);
            this.parkD7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD7.Name = "parkD7";
            this.parkD7.Size = new System.Drawing.Size(100, 100);
            this.parkD7.TabIndex = 28;
            this.parkD7.Text = "D7";
            this.parkD7.UseVisualStyleBackColor = false;
            this.parkD7.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkA6
            // 
            this.parkA6.BackColor = System.Drawing.Color.Green;
            this.parkA6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkA6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkA6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkA6.Location = new System.Drawing.Point(575, 175);
            this.parkA6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkA6.Name = "parkA6";
            this.parkA6.Size = new System.Drawing.Size(100, 100);
            this.parkA6.TabIndex = 27;
            this.parkA6.Text = "A6";
            this.parkA6.UseVisualStyleBackColor = false;
            this.parkA6.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkB6
            // 
            this.parkB6.BackColor = System.Drawing.Color.Green;
            this.parkB6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkB6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkB6.Location = new System.Drawing.Point(575, 280);
            this.parkB6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkB6.Name = "parkB6";
            this.parkB6.Size = new System.Drawing.Size(100, 100);
            this.parkB6.TabIndex = 26;
            this.parkB6.Text = "B6";
            this.parkB6.UseVisualStyleBackColor = false;
            this.parkB6.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkC6
            // 
            this.parkC6.BackColor = System.Drawing.Color.Green;
            this.parkC6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkC6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkC6.Location = new System.Drawing.Point(575, 499);
            this.parkC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkC6.Name = "parkC6";
            this.parkC6.Size = new System.Drawing.Size(100, 100);
            this.parkC6.TabIndex = 25;
            this.parkC6.Text = "C6";
            this.parkC6.UseVisualStyleBackColor = false;
            this.parkC6.Click += new System.EventHandler(this.parkingClick);
            // 
            // parkD6
            // 
            this.parkD6.BackColor = System.Drawing.Color.Green;
            this.parkD6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkD6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parkD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkD6.Location = new System.Drawing.Point(578, 605);
            this.parkD6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parkD6.Name = "parkD6";
            this.parkD6.Size = new System.Drawing.Size(100, 100);
            this.parkD6.TabIndex = 24;
            this.parkD6.Text = "D6";
            this.parkD6.UseVisualStyleBackColor = false;
            this.parkD6.Click += new System.EventHandler(this.parkingClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 389);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lblEspacio
            // 
            this.lblEspacio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacio.Location = new System.Drawing.Point(247, 51);
            this.lblEspacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(179, 38);
            this.lblEspacio.TabIndex = 45;
            this.lblEspacio.Text = "Espacio ";
            this.lblEspacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParking
            // 
            this.txtParking.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtParking.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtParking.Location = new System.Drawing.Point(250, 93);
            this.txtParking.Margin = new System.Windows.Forms.Padding(4);
            this.txtParking.Name = "txtParking";
            this.txtParking.ReadOnly = true;
            this.txtParking.Size = new System.Drawing.Size(175, 32);
            this.txtParking.TabIndex = 46;
            this.txtParking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.Orange;
            this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngreso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngreso.FlatAppearance.BorderSize = 4;
            this.btnIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngreso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(472, 77);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(183, 52);
            this.btnIngreso.TabIndex = 47;
            this.btnIngreso.Text = "Dar acceso";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_click);
            // 
            // globoAyuda
            // 
            this.globoAyuda.IsBalloon = true;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1154, 739);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.txtParking);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.parkA10);
            this.Controls.Add(this.parkB10);
            this.Controls.Add(this.parkC10);
            this.Controls.Add(this.parkD10);
            this.Controls.Add(this.parkA8);
            this.Controls.Add(this.parkB8);
            this.Controls.Add(this.parkC8);
            this.Controls.Add(this.parkD8);
            this.Controls.Add(this.parkA9);
            this.Controls.Add(this.parkB9);
            this.Controls.Add(this.parkC9);
            this.Controls.Add(this.parkD9);
            this.Controls.Add(this.parkA7);
            this.Controls.Add(this.parkB7);
            this.Controls.Add(this.parkC7);
            this.Controls.Add(this.parkD7);
            this.Controls.Add(this.parkA6);
            this.Controls.Add(this.parkB6);
            this.Controls.Add(this.parkC6);
            this.Controls.Add(this.parkD6);
            this.Controls.Add(this.parkA5);
            this.Controls.Add(this.parkB5);
            this.Controls.Add(this.parkC5);
            this.Controls.Add(this.parkD5);
            this.Controls.Add(this.parkA3);
            this.Controls.Add(this.parkB3);
            this.Controls.Add(this.parkC3);
            this.Controls.Add(this.parkD3);
            this.Controls.Add(this.parkA4);
            this.Controls.Add(this.parkB4);
            this.Controls.Add(this.parkC4);
            this.Controls.Add(this.parkD4);
            this.Controls.Add(this.parkA2);
            this.Controls.Add(this.parkB2);
            this.Controls.Add(this.parkC2);
            this.Controls.Add(this.parkD2);
            this.Controls.Add(this.parkA1);
            this.Controls.Add(this.parkB1);
            this.Controls.Add(this.parkC1);
            this.Controls.Add(this.parkD1);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso para estudiantes y visitantes";
            this.Load += new System.EventHandler(this.frmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEntrada;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button parkD1;
        private System.Windows.Forms.Button parkC1;
        private System.Windows.Forms.Button parkB1;
        private System.Windows.Forms.Button parkA1;
        private System.Windows.Forms.Button parkA2;
        private System.Windows.Forms.Button parkB2;
        private System.Windows.Forms.Button parkC2;
        private System.Windows.Forms.Button parkD2;
        private System.Windows.Forms.Button parkA4;
        private System.Windows.Forms.Button parkB4;
        private System.Windows.Forms.Button parkC4;
        private System.Windows.Forms.Button parkD4;
        private System.Windows.Forms.Button parkA3;
        private System.Windows.Forms.Button parkB3;
        private System.Windows.Forms.Button parkC3;
        private System.Windows.Forms.Button parkD3;
        private System.Windows.Forms.Button parkA5;
        private System.Windows.Forms.Button parkB5;
        private System.Windows.Forms.Button parkC5;
        private System.Windows.Forms.Button parkD5;
        private System.Windows.Forms.Button parkA10;
        private System.Windows.Forms.Button parkB10;
        private System.Windows.Forms.Button parkC10;
        private System.Windows.Forms.Button parkD10;
        private System.Windows.Forms.Button parkA8;
        private System.Windows.Forms.Button parkB8;
        private System.Windows.Forms.Button parkC8;
        private System.Windows.Forms.Button parkD8;
        private System.Windows.Forms.Button parkA9;
        private System.Windows.Forms.Button parkB9;
        private System.Windows.Forms.Button parkC9;
        private System.Windows.Forms.Button parkD9;
        private System.Windows.Forms.Button parkA7;
        private System.Windows.Forms.Button parkB7;
        private System.Windows.Forms.Button parkC7;
        private System.Windows.Forms.Button parkD7;
        private System.Windows.Forms.Button parkA6;
        private System.Windows.Forms.Button parkB6;
        private System.Windows.Forms.Button parkC6;
        private System.Windows.Forms.Button parkD6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEspacio;
        public System.Windows.Forms.TextBox txtParking;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.ToolTip globoAyuda;
    }
}