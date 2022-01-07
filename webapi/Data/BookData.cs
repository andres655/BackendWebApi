using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using Microsoft.Data.SqlClient;

namespace webapi.Data
{
    public class BookData
    {
        //llama al store procedure Agregar_Book
        public static bool Agregar_Book(Book book)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Agregar_Book", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", book.Id);
                cmd.Parameters.AddWithValue("@Titulo", book.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", book.Descripcion);
                cmd.Parameters.AddWithValue("@Autor", book.Autor);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }
        public static bool Modificar_Book(Book book)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Modificar_Book", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", book.Id);
                cmd.Parameters.AddWithValue("@Titulo", book.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", book.Descripcion);
                cmd.Parameters.AddWithValue("@Autor", book.Autor);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }
        public static List<Book> Listar()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("List_Book", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Autor = reader["Autor"].ToString()
                            });
                        }
                    }
                    return books;
                }
                catch (Exception ex)
                {
                    return books;
                }
            }
        }
        public static Book Obtener(int ID)
        {

            using (SqlConnection connection = new SqlConnection(Conexion.RutaConexion))
            {
                Book book = new Book();
                SqlCommand cmd = new SqlCommand("obtener_Book", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ID);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            book = new Book()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Autor = reader["Autor"].ToString()
                            };
                        }
                    }
                    return book;
                }
                catch (Exception ex)
                {
                    return book;
                }
            }
        }
        public static bool Eliminar(int ID)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.RutaConexion))
            {

                SqlCommand cmd = new SqlCommand("Eliminar_Book", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ID);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
    }
}