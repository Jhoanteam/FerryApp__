using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryNotificacion
    {
        public List<Notificacion> Listar()
        {
            List<Notificacion> lista = new List<Notificacion>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "CALL MostrarNotificaciones();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Notificacion
                            {
                                IdNotificacion = Convert.ToInt32(reader["IdNotificacion"]),
                                Titulo = reader["Titulo"].ToString(),
                                Texto = reader["Texto"].ToString(),
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Notificacion>();
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarNotificacion(string titulo, string texto, DateTime fechaRegistro, bool estado)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarNotificacion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Titulo", titulo);
                    cmd.Parameters.AddWithValue("@p_Texto", texto);
                    cmd.Parameters.AddWithValue("@p_FechaRegistro", fechaRegistro);
                    cmd.Parameters.AddWithValue("@p_Estado", estado);

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

        public void CambiarEstadoNotificacion(int idNotificacion, bool estado)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoNotificacion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_IdNotificacion", idNotificacion);
                    cmd.Parameters.AddWithValue("@p_Estado", estado);

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
