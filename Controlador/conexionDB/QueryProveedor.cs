using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryProveedor
    {

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM Proveedor;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proveedor
                            {
                                IdProveedor = Convert.ToInt32(reader["Id_proveedor"]),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Telefono1 = reader["Telefono1"].ToString(),
                                Telefono2 = reader["Telefono2"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                Nota = reader["Nota"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedor>();
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarProveedor(string razonSocial, string telefono1, string telefono2, string correo, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarProveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_RazonSocial", razonSocial);
                    cmd.Parameters.AddWithValue("@p_Telefono1", telefono1);
                    cmd.Parameters.AddWithValue("@p_Telefono2", telefono2);
                    cmd.Parameters.AddWithValue("@p_Correo", correo);
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

        public void CambiarEstadoProveedor(int idProveedor, bool estado)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoProveedor", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Id_proveedor", idProveedor);
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
    