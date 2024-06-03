namespace EXAMEN_FINAL_YEN
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
            this.Tabla_datos_ver = new System.Windows.Forms.DataGridView();
            this.Cargar = new System.Windows.Forms.Button();
            this.probar_conexion = new System.Windows.Forms.Button();
            this.dateTimeFECHA_CREAR = new System.Windows.Forms.DateTimePicker();
            this.textboxnombreArticulo = new System.Windows.Forms.TextBox();
            this.textboxTalla = new System.Windows.Forms.TextBox();
            this.textboxColor = new System.Windows.Forms.TextBox();
            this.textboxMaterial = new System.Windows.Forms.TextBox();
            this.checkDisponibildad = new System.Windows.Forms.CheckBox();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.precio_CAJA = new System.Windows.Forms.NumericUpDown();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            this.boton_BORRAR = new System.Windows.Forms.Button();
            this.Text_Codi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_datos_ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_CAJA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_datos_ver
            // 
            this.Tabla_datos_ver.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tabla_datos_ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_datos_ver.Location = new System.Drawing.Point(12, 309);
            this.Tabla_datos_ver.Name = "Tabla_datos_ver";
            this.Tabla_datos_ver.Size = new System.Drawing.Size(534, 129);
            this.Tabla_datos_ver.TabIndex = 0;
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.LawnGreen;
            this.Cargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cargar.Location = new System.Drawing.Point(691, 60);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(123, 52);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "MOSTRAR ARTICULOS";
            this.Cargar.UseVisualStyleBackColor = false;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // probar_conexion
            // 
            this.probar_conexion.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.b9b3dfb6e5afbe1b0c2de51fba05e2d2;
            this.probar_conexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.probar_conexion.Location = new System.Drawing.Point(575, 268);
            this.probar_conexion.Name = "probar_conexion";
            this.probar_conexion.Size = new System.Drawing.Size(92, 58);
            this.probar_conexion.TabIndex = 2;
            this.probar_conexion.Text = "PRUEBA DE CONEXION";
            this.probar_conexion.UseVisualStyleBackColor = true;
            this.probar_conexion.Click += new System.EventHandler(this.probar_conexion_Click);
            // 
            // dateTimeFECHA_CREAR
            // 
            this.dateTimeFECHA_CREAR.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimeFECHA_CREAR.Location = new System.Drawing.Point(575, 27);
            this.dateTimeFECHA_CREAR.Name = "dateTimeFECHA_CREAR";
            this.dateTimeFECHA_CREAR.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFECHA_CREAR.TabIndex = 3;
            // 
            // textboxnombreArticulo
            // 
            this.textboxnombreArticulo.Location = new System.Drawing.Point(160, 92);
            this.textboxnombreArticulo.Name = "textboxnombreArticulo";
            this.textboxnombreArticulo.Size = new System.Drawing.Size(100, 20);
            this.textboxnombreArticulo.TabIndex = 5;
            // 
            // textboxTalla
            // 
            this.textboxTalla.Location = new System.Drawing.Point(160, 135);
            this.textboxTalla.Name = "textboxTalla";
            this.textboxTalla.Size = new System.Drawing.Size(100, 20);
            this.textboxTalla.TabIndex = 6;
            // 
            // textboxColor
            // 
            this.textboxColor.Location = new System.Drawing.Point(160, 165);
            this.textboxColor.Name = "textboxColor";
            this.textboxColor.Size = new System.Drawing.Size(100, 20);
            this.textboxColor.TabIndex = 7;
            // 
            // textboxMaterial
            // 
            this.textboxMaterial.Location = new System.Drawing.Point(160, 191);
            this.textboxMaterial.Name = "textboxMaterial";
            this.textboxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textboxMaterial.TabIndex = 8;
            // 
            // checkDisponibildad
            // 
            this.checkDisponibildad.AutoSize = true;
            this.checkDisponibildad.BackColor = System.Drawing.Color.Transparent;
            this.checkDisponibildad.Location = new System.Drawing.Point(160, 268);
            this.checkDisponibildad.Name = "checkDisponibildad";
            this.checkDisponibildad.Size = new System.Drawing.Size(15, 14);
            this.checkDisponibildad.TabIndex = 11;
            this.checkDisponibildad.UseVisualStyleBackColor = false;
            // 
            // buttonagregar
            // 
            this.buttonagregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonagregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonagregar.Location = new System.Drawing.Point(574, 60);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(92, 58);
            this.buttonagregar.TabIndex = 12;
            this.buttonagregar.Text = "AGREGAR ARTICULO";
            this.buttonagregar.UseVisualStyleBackColor = false;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // precio_CAJA
            // 
            this.precio_CAJA.Location = new System.Drawing.Point(160, 229);
            this.precio_CAJA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.precio_CAJA.Name = "precio_CAJA";
            this.precio_CAJA.Size = new System.Drawing.Size(100, 20);
            this.precio_CAJA.TabIndex = 10;
            this.precio_CAJA.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton_Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boton_Actualizar.Location = new System.Drawing.Point(574, 124);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(92, 58);
            this.boton_Actualizar.TabIndex = 20;
            this.boton_Actualizar.Text = "ACTUALIZAR";
            this.boton_Actualizar.UseVisualStyleBackColor = false;
            this.boton_Actualizar.Click += new System.EventHandler(this.boton_Actualizar_Click);
            // 
            // boton_BORRAR
            // 
            this.boton_BORRAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton_BORRAR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.boton_BORRAR.Location = new System.Drawing.Point(575, 191);
            this.boton_BORRAR.Name = "boton_BORRAR";
            this.boton_BORRAR.Size = new System.Drawing.Size(92, 58);
            this.boton_BORRAR.TabIndex = 21;
            this.boton_BORRAR.Text = "ELIMINAR";
            this.boton_BORRAR.UseVisualStyleBackColor = false;
            this.boton_BORRAR.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // Text_Codi
            // 
            this.Text_Codi.Location = new System.Drawing.Point(160, 50);
            this.Text_Codi.Name = "Text_Codi";
            this.Text_Codi.Size = new System.Drawing.Size(100, 20);
            this.Text_Codi.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.Historia_de_Instagram_Collage_de_Fotos_Tienda_Nueva_Colección_MInimalista___1_1;
            this.pictureBox1.Location = new System.Drawing.Point(691, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 223);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.hola2;
            this.pictureBox2.Location = new System.Drawing.Point(343, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 83);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(343, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 191);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.yenciiiii12;
            this.pictureBox4.Location = new System.Drawing.Point(12, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(263, 275);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(575, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 58);
            this.button1.TabIndex = 26;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.b9b3dfb6e5afbe1b0c2de51fba05e2d2;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Text_Codi);
            this.Controls.Add(this.boton_BORRAR);
            this.Controls.Add(this.boton_Actualizar);
            this.Controls.Add(this.buttonagregar);
            this.Controls.Add(this.checkDisponibildad);
            this.Controls.Add(this.precio_CAJA);
            this.Controls.Add(this.textboxMaterial);
            this.Controls.Add(this.textboxColor);
            this.Controls.Add(this.textboxTalla);
            this.Controls.Add(this.textboxnombreArticulo);
            this.Controls.Add(this.dateTimeFECHA_CREAR);
            this.Controls.Add(this.probar_conexion);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Tabla_datos_ver);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_datos_ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_CAJA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabla_datos_ver;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button probar_conexion;
        private System.Windows.Forms.DateTimePicker dateTimeFECHA_CREAR;
        private System.Windows.Forms.TextBox textboxnombreArticulo;
        private System.Windows.Forms.TextBox textboxTalla;
        private System.Windows.Forms.TextBox textboxColor;
        private System.Windows.Forms.TextBox textboxMaterial;
        private System.Windows.Forms.CheckBox checkDisponibildad;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.NumericUpDown precio_CAJA;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.Button boton_BORRAR;
        private System.Windows.Forms.TextBox Text_Codi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
    }
}

