using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Ferriapp.Controlador
{
    internal class QueryUsuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM Users;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["id_user"]),
                                NombreUsuario = reader["NombreUser"].ToString(),
                                Contraseña = reader["Contraseña"].ToString(),
                                RolUsuario = reader["RolUser"].ToString(),
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No fue posible conectar al usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lista = new List<Usuario>();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public static void InsertarUsuario(string nombreUsuario, string contraseña, string rolUsuario, DateTime fechaRegistro)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NombreUser", nombreUsuario);
                    cmd.Parameters.AddWithValue("@p_Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@p_RolUser", rolUsuario);
                    cmd.Parameters.AddWithValue("@p_Fecharegistro", fechaRegistro);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No fue posible registrar al usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public static void CambiarEstadoUsuario(int idUsuario, bool estado)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoUsuario", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_user", idUsuario);
                    cmd.Parameters.AddWithValue("@p_Estado", estado);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No fue posible cambiar el estado del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
        public static void ModificarUsuario(int idUser, string nombreUser, string contraseña, string rolUser)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("ModificarUsuario", conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_id_user", idUser);
                cmd.Parameters.AddWithValue("p_NombreUser", nombreUser);
                cmd.Parameters.AddWithValue("p_Contraseña", contraseña);
                cmd.Parameters.AddWithValue("p_RolUser", rolUser);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
