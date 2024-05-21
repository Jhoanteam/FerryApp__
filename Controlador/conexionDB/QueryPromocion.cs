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
    internal class QueryPromociones
    {
        public List<Promocion> Listar()
        {
            List<Promocion> lista = new List<Promocion>();
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM Promociones;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Promocion
                            {
                                IdPromocion = Convert.ToInt32(reader["id_promocion"]),
                                NombrePromocion = reader["NombrePromocion"].ToString(),
                                CondicionesPromocion = reader["Condicionespromocion"].ToString(),
                                ValorDescuento = Convert.ToDouble(reader["ValorDescuento"]),
                                Disponible = Convert.ToBoolean(reader["Disponible"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Promocion>();
                    // Manejo de errores
                }
                finally
                {
                    conexion.Close();
                }
            }
            return lista;
        }

        public void InsertarPromocion(string nombrePromocion, string condicionesPromocion, double valorDescuento, bool disponible)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("InsertarPromocion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_NombrePromocion", nombrePromocion);
                    cmd.Parameters.AddWithValue("@p_Condicionespromocion", condicionesPromocion);
                    cmd.Parameters.AddWithValue("@p_ValorDescuento", valorDescuento);
                    cmd.Parameters.AddWithValue("@p_Disponible", disponible);

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

        public void CambiarDisponibilidadPromocion(int idPromocion, bool disponible)
        {
            using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("CambiarDisponibilidadPromocion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_promocion", idPromocion);
                    cmd.Parameters.AddWithValue("@p_Disponible", disponible);

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
