using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryCliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "CALL MostrarClientes();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["id_Cliente"]),
                                NombreCliente = reader["NombreCliente"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Domicilio = reader["Domicilio"].ToString(),
                                Contraseña = reader["Contraseña"].ToString(),
                                IdUser = Convert.ToInt32(reader["Id_user"]),
                                FechaRegistro = Convert.ToDateTime(reader["Fecharegistro"]),
                                Disponible = Convert.ToBoolean(reader["Disponible"]),
                                Nota = reader["Nota"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarCliente(string nombreCliente, string documento, string domicilio, string contraseña, int idUser, DateTime fechaRegistro, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarCliente", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NombreCliente", nombreCliente);
                    cmd.Parameters.AddWithValue("@p_Documento", documento);
                    cmd.Parameters.AddWithValue("@p_Domicilio", domicilio);
                    cmd.Parameters.AddWithValue("@p_Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@p_Id_user", idUser);
                    cmd.Parameters.AddWithValue("@p_Fecharegistro", fechaRegistro);
                    cmd.Parameters.AddWithValue("@p_Nota", nota);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public void CambiarDisponibilidadCliente(int idCliente, bool disponible, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarDisponibilidadCliente", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@p_Disponible", disponible);
                    cmd.Parameters.AddWithValue("@p_Nota", nota);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar disponibilidad del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
