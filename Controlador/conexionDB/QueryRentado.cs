using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryRentado
    {
        public List<Rentado> Listar()
        {
            List<Rentado> lista = new List<Rentado>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "CALL MostrarRentados();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Rentado
                            {
                                IdRentado = Convert.ToInt32(reader["id_Rentado"]),
                                NombreCliente = reader["NombreCliente"].ToString(),
                                NombreRenta = reader["NombreRenta"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                Nota = reader["Nota"].ToString(),
                                TipoRenta = reader["TipoRenta"].ToString(),
                                TiempoRenta = Convert.ToInt32(reader["TiempoRenta"]),
                                NombreUsuario = reader["NombreUser"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rentado>();
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarRentado(int idCliente, string nombreRenta, string descripcion, bool estado, string nota, string tipoRenta, int tiempoRenta, int idUser)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarRentado", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_Cliente", idCliente);
                    cmd.Parameters.AddWithValue("@p_NombreRenta", nombreRenta);
                    cmd.Parameters.AddWithValue("@p_Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@p_Estado", estado);
                    cmd.Parameters.AddWithValue("@p_Nota", nota);
                    cmd.Parameters.AddWithValue("@p_TipoRenta", tipoRenta);
                    cmd.Parameters.AddWithValue("@p_TiempoRenta", tiempoRenta);
                    cmd.Parameters.AddWithValue("@p_id_user", idUser);

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

        public void CambiarEstadoRentado(int idRentado, bool estado, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoRentado", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_rentado", idRentado);
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
