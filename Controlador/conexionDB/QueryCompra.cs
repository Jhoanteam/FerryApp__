using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryCompra
    {
        public List<Compra> Listar()
        {
            List<Compra> lista = new List<Compra>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "CALL MostrarCompras();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Compra
                            {
                                IdCompra = Convert.ToInt32(reader["id_Compra"]),
                                Usuario = reader["Usuario"].ToString(),
                                Proveedor = reader["Proveedor"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                ValorCompra = Convert.ToDouble(reader["valorCompra"]),
                                FechaRegistro = Convert.ToDateTime(reader["Fecharegistro"]),
                                Nota = reader["Nota"].ToString(),
                                Estado = true // El estado se establece como verdadero por defecto
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    lista = new List<Compra>();
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void Insertar(Compra compra,int IdUser, int IdProveedor)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarCompra", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_user", IdUser);
                    cmd.Parameters.AddWithValue("@p_id_proveedor", IdProveedor);
                    cmd.Parameters.AddWithValue("@p_descripcion", compra.Descripcion);
                    cmd.Parameters.AddWithValue("@p_valorCompra", compra.ValorCompra);
                    cmd.Parameters.AddWithValue("@p_Fecharegistro", compra.FechaRegistro);
                    cmd.Parameters.AddWithValue("@p_Nota", compra.Nota);

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

        public void CambiarEstado(int idCompra, bool estado, string nota)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoCompra", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_compra", idCompra);
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

