using Ferriapp.Controlador.Entidades;
using MySql.Data.MySqlClient;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Ferriapp.Controlador.conexionDB
{
    internal class QueryStoc
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "call MostrarProductos();";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = Convert.ToInt32(reader["id_Producto"]),
                                Proveedor = reader["Proveedor"].ToString(),
                                NombreProducto = reader["NombreProducto"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Existencias = Convert.ToInt32(reader["existencias"]),
                                ExistenciasMin = Convert.ToInt32(reader["existenciasmin"]),
                                ValorCompraUnitario = Convert.ToDouble(reader["ValorCompra_unitario"]),
                                ValorVentaUnitario = Convert.ToDouble(reader["ValorVenta_unitario"]),
                                Imagen = reader["Imagen"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Producto>();

                    DialogResult result = MessageBox.Show("El usuario ya existe pero está inactivo. ¿Desea reactivarlo?", "Reactivar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarProducto(int idProveedor, string nombreProducto, string categoria, string descripcion, int existencias, int existenciasMin, double valorCompraUnitario, double valorVentaUnitario, string imagen)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarProducto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_proveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@p_NombreProducto", nombreProducto);
                    cmd.Parameters.AddWithValue("@p_Categoria", categoria);
                    cmd.Parameters.AddWithValue("@p_Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@p_existencias", existencias);
                    cmd.Parameters.AddWithValue("@p_existenciasmin", existenciasMin);
                    cmd.Parameters.AddWithValue("@p_ValorCompra_unitario", valorCompraUnitario);
                    cmd.Parameters.AddWithValue("@p_ValorVenta_unitario", valorVentaUnitario);
                    cmd.Parameters.AddWithValue("@p_Imagen", imagen);

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

        public void CambiarEstadoProducto(int idProducto, bool estado)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarEstadoProducto", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Id_producto", idProducto);
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
