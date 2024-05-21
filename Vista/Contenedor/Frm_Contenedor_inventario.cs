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
    public partial class Frm_Contenedor_inventario : Form
    {
        private static Form FormularioActivo = null;
        public Frm_Contenedor_inventario()
        {
            InitializeComponent();
            ActivarFormulario(new Frm_Inventario());
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
        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            ActivarFormulario(new Frm_Inventario());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            ActivarFormulario(new SubForms.Frm_Proveedor());
        }
    }
}
