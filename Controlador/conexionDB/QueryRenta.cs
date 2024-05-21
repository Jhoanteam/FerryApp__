using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryRenta
    {
        public List<Renta> Listar()
        {
            List<Renta> lista = new List<Renta>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("MostrarRentas", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Renta
                            {
                                IdRenta = Convert.ToInt32(reader["id_Renta"]),
                                Proveedor = reader["Proveedor"].ToString(),
                                NombreRenta = reader["NombreRenta"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                ValorxDia = Convert.ToDouble(reader["ValorxDia"]),
                                ValorxHora = Convert.ToDouble(reader["ValorxHora"]),
                                Imagen = reader["Imagen"].ToString(),
                                Disponible = Convert.ToBoolean(reader["Disponible"]),
                                Nota = reader["Nota"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarRenta(int idProveedor, string nombreRenta, string categoria, string descripcion, double valorxDia, double valorxHora, string imagen, bool disponible, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarRenta", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_proveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@p_NombreRenta", nombreRenta);
                    cmd.Parameters.AddWithValue("@p_Categoria", categoria);
                    cmd.Parameters.AddWithValue("@p_Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@p_ValorxDia", valorxDia);
                    cmd.Parameters.AddWithValue("@p_ValorxHora", valorxHora);
                    cmd.Parameters.AddWithValue("@p_Imagen", imagen);
                    cmd.Parameters.AddWithValue("@p_Disponible", disponible);
                    cmd.Parameters.AddWithValue("@p_Nota", nota);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void CambiarDisponibilidadRenta(int idRenta, bool disponible, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarDisponibilidadRenta", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_renta", idRenta);
                    cmd.Parameters.AddWithValue("@p_Disponible", disponible);
                    cmd.Parameters.AddWithValue("@p_Nota", nota);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
