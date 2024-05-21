using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ferriapp.Vista.SubForms
{
    public partial class Frm_Proveedor : Form
    {
        public Frm_Proveedor()
        {
            InitializeComponent();
            ActualizarlistaUsuario();
        }
        public void ActualizarlistaUsuario()
        {
            try
            {
                if (dataGridView1 == null)
                {
                    MessageBox.Show("El control dataGridView1 no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView1.Rows.Clear();
                List<Proveedor> listaUsuario = new QueryProveedor().Listar();
                foreach (Proveedor item in listaUsuario)
                {

                    dataGridView1.Rows.Add(new object[] { item.IdProveedor, item.RazonSocial, item.Telefono1, item.Telefono2, item.Correo, item.Estado, item.Nota });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la lista de proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
