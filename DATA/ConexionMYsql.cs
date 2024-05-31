using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAMEN_FINAL_YEN.DATA
{
    internal class ConexionMYsql
    {

        private string connectionString = "Server=localhost;Database=tienda_hm;Uid=root;Pwd=ana21hm";

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {



                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }



            }

        }

        public DataTable Mostrar()
        {

            DataTable articulosver = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {







                connection.Open();


                string sql = "Select * from articulos";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {



                        adapter.Fill(articulosver);

                    }



                }


            }
            return articulosver;







        }





        public int CrearArticulo(int codigo, string Nombre_Articulo, string Talla, string Color, string Material, decimal Precio, DateTime Fecha_De_ingreso, bool Disponibilidad)
        {
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO articulos (codigo, Nombre_Articulo, Talla, Color, Material, Precio, Fecha_De_ingreso, Disponibilidad) VALUES (@codigo, @Nombre_Articulo, @Talla, @Color, @Material, @Precio, @Fecha_De_ingreso, @Disponibilidad)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", codigo);
                        command.Parameters.AddWithValue("@Nombre_Articulo", Nombre_Articulo);
                        command.Parameters.AddWithValue("@Talla", Talla);
                        command.Parameters.AddWithValue("@Color", Color);
                        command.Parameters.AddWithValue("@Material", Material);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Fecha_De_ingreso", Fecha_De_ingreso);
                        command.Parameters.AddWithValue("@Disponibilidad", Disponibilidad);
                        return command.ExecuteNonQuery();
                    }
                }







            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine($"Error de MySQL: {ex.Message}");
               
                return -1;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error general: {ex.Message}");
              
                return -1;
            }
        }

        public void Actualizar(int codigo, string Nombre_Articulo, string Talla, string Color, string Material, decimal Precio, DateTime Fecha_De_ingreso, bool Disponibilidad)
        {
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE articulos SET Nombre_Articulo = @Nombre_Articulo, Talla = @Talla, Color = @Color, Material = @Material, Precio = @Precio, Fecha_De_ingreso = @Fecha_De_ingreso, Disponibilidad = @Disponibilidad WHERE codigo = @codigo";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", codigo);
                        command.Parameters.AddWithValue("@Nombre_Articulo", Nombre_Articulo);
                        command.Parameters.AddWithValue("@Talla", Talla);
                        command.Parameters.AddWithValue("@Color", Color);
                        command.Parameters.AddWithValue("@Material", Material);
                        command.Parameters.AddWithValue("@Precio", Precio);
                        command.Parameters.AddWithValue("@Fecha_De_ingreso", Fecha_De_ingreso);
                        command.Parameters.AddWithValue("@Disponibilidad", Disponibilidad);
                        command.ExecuteNonQuery();
                    }
                }
            }




        }



        public void Eliminar(int codigo)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM articulos WHERE codigo = @codigo";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@codigo", codigo);

                    command.ExecuteNonQuery();
                }
            }
        }










    }//CIERRE1
}//CIERRE2