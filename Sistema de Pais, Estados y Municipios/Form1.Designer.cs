namespace Sistema_de_Pais__Estados_y_Municipios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.listBoxMunicipios = new System.Windows.Forms.ListBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelMunicipio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonConexion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelAutor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxPais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxPais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            "México"});
            this.comboBoxPais.Location = new System.Drawing.Point(191, 22);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(205, 22);
            this.comboBoxPais.TabIndex = 0;
            this.comboBoxPais.SelectedIndexChanged += new System.EventHandler(this.comboBoxPais_SelectedIndexChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEstado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.comboBoxEstado.Location = new System.Drawing.Point(191, 63);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(205, 22);
            this.comboBoxEstado.TabIndex = 1;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // listBoxMunicipios
            // 
            this.listBoxMunicipios.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxMunicipios.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMunicipios.FormattingEnabled = true;
            this.listBoxMunicipios.ItemHeight = 14;
            this.listBoxMunicipios.Location = new System.Drawing.Point(191, 106);
            this.listBoxMunicipios.Name = "listBoxMunicipios";
            this.listBoxMunicipios.Size = new System.Drawing.Size(205, 102);
            this.listBoxMunicipios.TabIndex = 2;
            this.listBoxMunicipios.SelectedIndexChanged += new System.EventHandler(this.listBoxMunicipios_SelectedIndexChanged);
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPais.Location = new System.Drawing.Point(14, 22);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(40, 19);
            this.labelPais.TabIndex = 3;
            this.labelPais.Text = "Pais:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(14, 63);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(57, 19);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado:";
            // 
            // labelMunicipio
            // 
            this.labelMunicipio.AutoSize = true;
            this.labelMunicipio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMunicipio.Location = new System.Drawing.Point(14, 106);
            this.labelMunicipio.Name = "labelMunicipio";
            this.labelMunicipio.Size = new System.Drawing.Size(84, 19);
            this.labelMunicipio.TabIndex = 5;
            this.labelMunicipio.Text = "Municipios:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 339);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPEM.Properties.Resources.INEGI2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sistema de Pais, Estados y Municipios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(80)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(99, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 38);
            this.panel2.TabIndex = 9;
            // 
            // botonConexion
            // 
            this.botonConexion.Location = new System.Drawing.Point(269, 225);
            this.botonConexion.Name = "botonConexion";
            this.botonConexion.Size = new System.Drawing.Size(127, 30);
            this.botonConexion.TabIndex = 10;
            this.botonConexion.Text = "Establecer conexión";
            this.botonConexion.UseVisualStyleBackColor = true;
            this.botonConexion.Click += new System.EventHandler(this.botonConexion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.labelAutor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(99, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 25);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxEstado);
            this.panel4.Controls.Add(this.comboBoxPais);
            this.panel4.Controls.Add(this.botonConexion);
            this.panel4.Controls.Add(this.listBoxMunicipios);
            this.panel4.Controls.Add(this.labelMunicipio);
            this.panel4.Controls.Add(this.labelPais);
            this.panel4.Controls.Add(this.labelEstado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(99, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 276);
            this.panel4.TabIndex = 12;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(329, 3);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(96, 15);
            this.labelAutor.TabIndex = 11;
            this.labelAutor.Text = "Juan Carlos Chuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(527, 339);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ListBox listBoxMunicipios;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelMunicipio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonConexion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelAutor;
    }
}

