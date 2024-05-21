using Ferriapp.Controlador;
using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferriapp.Vista.Contenedor
{
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
            ActualizarlistaStoc();
        }
        public void ActualizarlistaStoc()
        {
            try
            {
                if (dataGridView1 == null)
                {
                    MessageBox.Show("El control dataGridView1 no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView1.Rows.Clear();
                List<Producto> listaProducto = new Controlador.Listado.ListadoProducto().Listar();
                foreach (Producto item in listaProducto)
                {

                    dataGridView1.Rows.Add(new object[] { item.IdProducto, item.NombreProducto, item.Proveedor, item.Categoria, item.Existencias,item.Descripcion ,item.ValorVentaUnitario  });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la lista de proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
