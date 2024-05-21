using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ferriapp.Controlador
{
    public class Conexion
    {
        public static string cadena = "server=roundhouse.proxy.rlwy.net;port=55464;database=railway;uid=root;password=MsCxZiqUjuZTmLBDThERbWEaeNzsHHyg;";

        public MySqlConnection AbrirConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible conectar con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception("Error al intentar abrir la conexión.", ex);
                
            }
        }
    }
}
