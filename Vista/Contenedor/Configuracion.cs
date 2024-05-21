using Ferriapp.Controlador;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ferriapp.Vista.Contenedor
{

    public partial class Configuracion : Form
    {
        public int seleccionado;
        public Configuracion()
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
                List<Usuario> listaUsuario = new QueryUsuario().Listar();
                foreach (Usuario item in listaUsuario)
                {
                    if (item.Estado)
                    {
                        dataGridView1.Rows.Add(new object[] { item.IdUsuario, item.NombreUsuario, item.RolUsuario, item.Estado, item.FechaRegistro });
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la lista de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Manejo del evento TextChanged
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valorCelda = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (valorCelda != null)
                {
                    seleccionado = Convert.ToInt32(valorCelda);
                    List<Usuario> listaUsuario = new QueryUsuario().Listar();
                    Usuario usuarioSeleccionado = listaUsuario.FirstOrDefault(us => us.IdUsuario == seleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        Lb_ID.Text = usuarioSeleccionado.IdUsuario.ToString();
                        Txt_Nombre.Text = usuarioSeleccionado.NombreUsuario;
                        Txt_Rol.Text = usuarioSeleccionado.RolUsuario;
                        Txt_Contraseña.Text = usuarioSeleccionado.Contraseña;
                    }
                }
            }
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

            if (Txt_Nombre.Text != "")
            {
                dataGridView1.Rows.Clear();
                List<Usuario> listaUsuario = new QueryUsuario().Listar();
                Usuario usuarioencontrado = listaUsuario.FirstOrDefault(us => us.NombreUsuario == Txt_Nombre.Text);
                foreach (Usuario item in listaUsuario)
                {
                    if (usuarioencontrado != null)
                    {
                        if (usuarioencontrado.Estado)
                        {

                            if (Txt_Rol.Text != "")
                            {


                                try
                                {
                                    int Id = Convert.ToInt32(Lb_ID.Text);

                                    QueryUsuario.ModificarUsuario(Id, Txt_Nombre.Text, Txt_Contraseña.Text, Txt_Rol.Text);
                                }
                                catch
                                {
                                    MessageBox.Show("no fue posible mocificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                MessageBox.Show("modificado con exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                ActualizarlistaUsuario();
                                return;
                            }


                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("El usuario ya existe pero está inactivo. ¿Desea reactivarlo?", "Reactivar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                QueryUsuario.CambiarEstadoUsuario(item.IdUsuario, true);
                                ActualizarlistaUsuario();
                                return;
                            }
                        }

                    }
                    else
                    {

                        DateTime dateTime = DateTime.Now;
                        try
                        {
                            QueryUsuario.InsertarUsuario(Txt_Nombre.Text, Txt_Contraseña.Text, Txt_Rol.Text, dateTime);
                        }
                        catch
                        {
                            MessageBox.Show("No fue pocible Agregar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                        ActualizarlistaUsuario();
                        return;
                    }
                }
            }

        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                QueryUsuario.CambiarEstadoUsuario(seleccionado, false);

                ActualizarlistaUsuario();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valorCelda = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (valorCelda != null)
                {
                    seleccionado = Convert.ToInt32(valorCelda);
                    List<Usuario> listaUsuario = new QueryUsuario().Listar();
                    Usuario usuarioSeleccionado = listaUsuario.FirstOrDefault(us => us.IdUsuario == seleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        Lb_ID.Text = usuarioSeleccionado.IdUsuario.ToString();
                        Txt_Nombre.Text = usuarioSeleccionado.NombreUsuario;
                        Txt_Rol.Text = usuarioSeleccionado.RolUsuario;
                        Txt_Contraseña.Text = usuarioSeleccionado.Contraseña;
                        Txt_FechaRegistro.Text = usuarioSeleccionado.FechaRegistro.ToString();
                    }
                }
            }
        }
    }
}
