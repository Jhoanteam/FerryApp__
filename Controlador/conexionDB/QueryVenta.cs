using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryVenta
    {

        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "CALL MostrarVentas();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = Convert.ToInt32(reader["id_Venta"]),
                                Usuario = reader["Usuario"].ToString(),
                                FechaRegistro = Convert.ToDateTime(reader["Fecharegistro"]),
                                Productos = reader["Productos"].ToString(),
                                ValorVenta = Convert.ToDouble(reader["ValorVenta"]),
                                Promocion = reader["Promocion"].ToString(),
                                ValorFinal = Convert.ToDouble(reader["ValorFinal"]),
                                Nota = reader["Nota"].ToString(),
                                Estado = true // El estado se establece como verdadero por defecto
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    lista = new List<Venta>();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void Insertar(Venta venta,int IdUsuario, int IdPromocion)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarVenta", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_user", IdUsuario);
                    cmd.Parameters.AddWithValue("@p_Fecharegistro", venta.FechaRegistro);
                    cmd.Parameters.AddWithValue("@p_Productos", venta.Productos);
                    cmd.Parameters.AddWithValue("@p_ValorVenta", venta.ValorVenta);
                    cmd.Parameters.AddWithValue("@p_id_promocion", IdPromocion);
                    cmd.Parameters.AddWithValue("@p_ValorFinal", venta.ValorFinal);
                    cmd.Parameters.AddWithValue("@p_Nota", venta.Nota);

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

        public void CambiarEstado(int idVenta, bool estado, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoVenta", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_venta", idVenta);
                    cmd.Parameters.AddWithValue("@p_Estado", estado);
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
