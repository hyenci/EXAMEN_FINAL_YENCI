using EXAMEN_FINAL_YEN.DATA;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAMEN_FINAL_YEN
{
    public partial class Form1 : Form
    {

        private ConexionMYsql articulo1;
        private readonly string connectionString;

        public Form1()
        {
            InitializeComponent();
            articulo1 = new ConexionMYsql();

        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void probar_conexion_Click(object sender, EventArgs e)
        {
            if (articulo1.ProbarConexion())
            {


                MessageBox.Show("SI SE PUDO");


            }
            else
            {
                MessageBox.Show("NEL PASTEl");
            }
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            Tabla_datos_ver.DataSource = articulo1.Mostrar();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {

           
            int codigo = int.Parse(Text_Codi.Text);
            string Nombre_Articulo = textboxnombreArticulo.Text;
            string Talla = textboxTalla.Text;
            string Color = textboxColor.Text;
            string Material = textboxMaterial.Text;
            decimal Precio = (decimal)precio_CAJA.Value;
            DateTime Fecha_De_ingreso = dateTimeFECHA_CREAR.Value;
            bool Disponibilidad = checkDisponibildad.Checked;

            if (Text_Codi.Text == "" || textboxnombreArticulo.Text == "" || textboxTalla.Text == "" || textboxColor.Text == "" || textboxMaterial.Text == "" || precio_CAJA.Value == 0)
            {
                MessageBox.Show("UN CAMPO ESTA VACIO, POR FAVOR LLENARLO");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea crear un nuevo artículo?", "Confirmar creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)

                {


                    int respuesta = articulo1.CrearArticulo(codigo, Nombre_Articulo, Talla, Color, Material, Precio, Fecha_De_ingreso, Disponibilidad);

                    if (respuesta > 0)
                    {


                        MessageBox.Show("Artículo creado correctamente");



                        Tabla_datos_ver.DataSource = respuesta;
                    }
                    else
                    {


                        MessageBox.Show("Error al crear el artículo");
                    }
                }
                else

                {


                    MessageBox.Show("Creación cancelada");




                }
            }

           








        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Actualizar()
        {
            int codigo = int.Parse(Text_Codi.Text);
            string Nombre_Articulo = textboxnombreArticulo.Text;
            string Talla = textboxTalla.Text;
            string Color = textboxColor.Text;
            string Material = textboxMaterial.Text;
            decimal Precio = (decimal)precio_CAJA.Value;
            DateTime Fecha_De_ingreso = dateTimeFECHA_CREAR.Value;
            bool Disponibilidad = checkDisponibildad.Checked;

            articulo1.Actualizar(codigo, Nombre_Articulo, Talla, Color, Material, Precio, Fecha_De_ingreso, Disponibilidad);

            MessageBox.Show("Personaje actualizado correctamente.");
        }


        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(textboxnombreArticulo.Text))
            {
                MessageBox.Show("El nombre del artículo no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textboxTalla.Text))
            {
                MessageBox.Show("La talla no puede estar vacía.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textboxColor.Text))
            {
                MessageBox.Show("El color no puede estar vacío.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textboxMaterial.Text))
            {
                MessageBox.Show("El material no puede estar vacío.");
                return false;
            }

            if (precio_CAJA.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que 0.");
                return false;
            }

            if (dateTimeFECHA_CREAR.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de ingreso no puede ser una fecha futura.");
                return false;
            }

            return true;
        }





        private void boton_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    DialogResult result = MessageBox.Show("¿Quieres actualizar este artículo?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Actualización cancelada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }







       

        private void LimpiarControles()
        {
            // Limpiar los controles después de la eliminación si es necesario
            textboxTalla.Clear();
            textboxnombreArticulo.Clear();
            textboxMaterial.Clear();
            textboxColor.Clear();
            Text_Codi.Clear();
           precio_CAJA.Accelerations.Clear();
           checkDisponibildad.Checked = false;

            dateTimeFECHA_CREAR.Value = DateTime.Now;
            

            Tabla_datos_ver.DataSource = null;

        }
        private void boton_Buscar_Click(object sender, EventArgs e)
        {

            try
            {
                int idEliminar = int.Parse(Text_Codi.Text);

                // Llamar a la función EliminarPersonaje con el ID del personaje
                articulo1.Eliminar(idEliminar);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Personaje eliminado correctamente.");

                // Limpiar los controles después de la eliminación si es necesario
                LimpiarControles();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir
                MessageBox.Show($"Error al eliminar el personaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Text_Codi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboxTalla.Clear();
            textboxnombreArticulo.Clear();
            textboxMaterial.Clear();
            textboxColor.Clear();
            Text_Codi.Clear();
            precio_CAJA.Value = 0;
            checkDisponibildad.Checked = false;

            dateTimeFECHA_CREAR.Value = DateTime.Now;


            Tabla_datos_ver.DataSource = null;
        }
    }
}
