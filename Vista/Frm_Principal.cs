using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ferriapp.Vista
{
    public partial class Frm_Principal : Form
    {
        private static Form FormularioActivo = null;
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        string NombreUsyario;
        string Rol;
        public Frm_Principal(string nombreUsuario, String RolUsuario)
        {

            InitializeComponent();
            NombreUsyario = nombreUsuario;
            Rol = RolUsuario;
            inicio();
            ActivarFormulario(new Contenedor.Frm_Venta());
            resetcolor();
            BTN_Venta.ForeColor = System.Drawing.Color.White;
            BTN_Venta.IconColor = System.Drawing.Color.White;
            BTN_Venta.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            // Asocia el evento MouseDown al panel2
            panel2.MouseDown += new MouseEventHandler(panel2_MouseDown);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void inicio()
        {
            label1.Text = Rol.ToString();
            label2.Text = NombreUsyario;
            if (Rol != "Admin")
            {
                if (Rol == "Rcepcionista")
                {
                    Btn_Configuracion.Visible = false;
                }
                if (Rol == "Bodega")
                {
                    BTN_Venta.Visible = false;
                    Btn_Estadisticas.Visible = false;
                    Btn_Configuracion.Visible = false;
                }
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

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Login_frm login_Frm = new Login_frm();
            login_Frm.Show();
            this.Close();
        }
        private void resetcolor()
        {
            BTN_Venta.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            BTN_Venta.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            BTN_Venta.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_gasto.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_gasto.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_gasto.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Inventario.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Inventario.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Inventario.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Estadisticas.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Estadisticas.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Estadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Renta.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Renta.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Renta.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Configuracion.ForeColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Configuracion.IconColor = System.Drawing.Color.FromArgb(0, 126, 149);
            Btn_Configuracion.ImageAlign = ContentAlignment.MiddleLeft;
        }
        private void ActivarFormulario(Form FormulaFormularioActivo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = FormulaFormularioActivo;
            FormulaFormularioActivo.TopLevel = false;
            FormulaFormularioActivo.FormBorderStyle = FormBorderStyle.None;
            FormulaFormularioActivo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(FormulaFormularioActivo);
            FormulaFormularioActivo.Show();

        }
        private void BTN_Venta_Click(object sender, EventArgs e)
        {
            resetcolor();
            BTN_Venta.ForeColor = System.Drawing.Color.White;
            BTN_Venta.IconColor = System.Drawing.Color.White;
            BTN_Venta.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Frm_Venta());
        }

        private void Btn_gasto_Click(object sender, EventArgs e)
        {
            resetcolor();
            Btn_gasto.ForeColor = System.Drawing.Color.White;
            Btn_gasto.IconColor = System.Drawing.Color.White;
            Btn_gasto.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Frm_Gasto());
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            resetcolor();
            Btn_Inventario.ForeColor = System.Drawing.Color.White;
            Btn_Inventario.IconColor = System.Drawing.Color.White;
            Btn_Inventario.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Frm_Contenedor_inventario());
        }

        private void Btn_Estadisticas_Click(object sender, EventArgs e)
        {
            resetcolor();
            Btn_Estadisticas.ForeColor = System.Drawing.Color.White;
            Btn_Estadisticas.IconColor = System.Drawing.Color.White;
            Btn_Estadisticas.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Frm_Estadisticas());
        }

        private void Btn_Renta_Click(object sender, EventArgs e)
        {
            resetcolor();
            Btn_Renta.ForeColor = System.Drawing.Color.White;
            Btn_Renta.IconColor = System.Drawing.Color.White;
            Btn_Renta.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Frm_Renta());
        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            resetcolor();
            Btn_Configuracion.ForeColor = System.Drawing.Color.White;
            Btn_Configuracion.IconColor = System.Drawing.Color.White;
            Btn_Configuracion.ImageAlign = ContentAlignment.MiddleRight;
            ActivarFormulario(new Contenedor.Configuracion());
        }
    }
}
