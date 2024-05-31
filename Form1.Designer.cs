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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            this.boton_BORRAR = new System.Windows.Forms.Button();
            this.Text_Codi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_datos_ver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_CAJA)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_datos_ver
            // 
            this.Tabla_datos_ver.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tabla_datos_ver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_datos_ver.Location = new System.Drawing.Point(12, 288);
            this.Tabla_datos_ver.Name = "Tabla_datos_ver";
            this.Tabla_datos_ver.Size = new System.Drawing.Size(534, 150);
            this.Tabla_datos_ver.TabIndex = 0;
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(623, 62);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(123, 52);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "MOSTRAR ARTICULOS";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // probar_conexion
            // 
            this.probar_conexion.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.b9b3dfb6e5afbe1b0c2de51fba05e2d2;
            this.probar_conexion.Location = new System.Drawing.Point(462, 27);
            this.probar_conexion.Name = "probar_conexion";
            this.probar_conexion.Size = new System.Drawing.Size(84, 58);
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
            this.textboxnombreArticulo.Location = new System.Drawing.Point(92, 51);
            this.textboxnombreArticulo.Name = "textboxnombreArticulo";
            this.textboxnombreArticulo.Size = new System.Drawing.Size(100, 20);
            this.textboxnombreArticulo.TabIndex = 5;
            // 
            // textboxTalla
            // 
            this.textboxTalla.Location = new System.Drawing.Point(92, 79);
            this.textboxTalla.Name = "textboxTalla";
            this.textboxTalla.Size = new System.Drawing.Size(100, 20);
            this.textboxTalla.TabIndex = 6;
            // 
            // textboxColor
            // 
            this.textboxColor.Location = new System.Drawing.Point(92, 116);
            this.textboxColor.Name = "textboxColor";
            this.textboxColor.Size = new System.Drawing.Size(100, 20);
            this.textboxColor.TabIndex = 7;
            // 
            // textboxMaterial
            // 
            this.textboxMaterial.Location = new System.Drawing.Point(92, 153);
            this.textboxMaterial.Name = "textboxMaterial";
            this.textboxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textboxMaterial.TabIndex = 8;
            // 
            // checkDisponibildad
            // 
            this.checkDisponibildad.AutoSize = true;
            this.checkDisponibildad.Location = new System.Drawing.Point(49, 239);
            this.checkDisponibildad.Name = "checkDisponibildad";
            this.checkDisponibildad.Size = new System.Drawing.Size(70, 17);
            this.checkDisponibildad.TabIndex = 11;
            this.checkDisponibildad.Text = "En Stock";
            this.checkDisponibildad.UseVisualStyleBackColor = true;
            // 
            // buttonagregar
            // 
            this.buttonagregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonagregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonagregar.Location = new System.Drawing.Point(639, 124);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(92, 58);
            this.buttonagregar.TabIndex = 12;
            this.buttonagregar.Text = "AGREGAR ARTICULO";
            this.buttonagregar.UseVisualStyleBackColor = false;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // precio_CAJA
            // 
            this.precio_CAJA.Location = new System.Drawing.Point(92, 191);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "TALLA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "COLOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "MATERIAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "PRECIO";
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.BackColor = System.Drawing.Color.Aquamarine;
            this.boton_Actualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_Actualizar.Location = new System.Drawing.Point(639, 198);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(92, 58);
            this.boton_Actualizar.TabIndex = 20;
            this.boton_Actualizar.Text = "ACTUALIZAR";
            this.boton_Actualizar.UseVisualStyleBackColor = false;
            this.boton_Actualizar.Click += new System.EventHandler(this.boton_Actualizar_Click);
            // 
            // boton_BORRAR
            // 
            this.boton_BORRAR.BackColor = System.Drawing.Color.Aquamarine;
            this.boton_BORRAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_BORRAR.Location = new System.Drawing.Point(639, 288);
            this.boton_BORRAR.Name = "boton_BORRAR";
            this.boton_BORRAR.Size = new System.Drawing.Size(92, 58);
            this.boton_BORRAR.TabIndex = 21;
            this.boton_BORRAR.Text = "ELIMINAR";
            this.boton_BORRAR.UseVisualStyleBackColor = false;
            this.boton_BORRAR.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // Text_Codi
            // 
            this.Text_Codi.Location = new System.Drawing.Point(92, 24);
            this.Text_Codi.Name = "Text_Codi";
            this.Text_Codi.Size = new System.Drawing.Size(100, 20);
            this.Text_Codi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EXAMEN_FINAL_YEN.Properties.Resources.b9b3dfb6e5afbe1b0c2de51fba05e2d2;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.Text_Codi);
            this.Controls.Add(this.boton_BORRAR);
            this.Controls.Add(this.boton_Actualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_datos_ver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_CAJA)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.Button boton_BORRAR;
        private System.Windows.Forms.TextBox Text_Codi;
    }
}

