using Ferriapp.Controlador.Entidades;
using Ferriapp.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ferriapp
{
    public partial class Login_frm : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public Login_frm()
        {
            InitializeComponent();
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            // Asocia el evento MouseDown al formulario
            this.MouseDown += new MouseEventHandler(Login_frm_MouseDown);
        }

        private void Login_frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario != null)
            {
                if (TXT_Contraceña.Text != "")
                {
                    List<Usuario> test = new Controlador.ListadoUsuario().Listar();
                    Usuario ousuario = new Controlador.ListadoUsuario().Listar().Where(u => u.NombreUsuario == txt_Usuario.Text && u.Contraseña == TXT_Contraceña.Text).FirstOrDefault();

                    if (ousuario != null)
                    {
                        if(ousuario.Estado){
                        Frm_Principal fp = new Frm_Principal(ousuario.NombreUsuario,ousuario.RolUsuario);
                        fp.Show();
                        txt_Usuario.Text = "";
                        TXT_Contraceña.Text = "";
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("El usuario: " + txt_Usuario.Text + "esta desactivado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario: " + txt_Usuario.Text + " no fue encontrado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
