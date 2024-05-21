using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string Proveedor { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Existencias { get; set; }
        public int ExistenciasMin { get; set; }
        public double ValorCompraUnitario { get; set; }
        public double ValorVentaUnitario { get; set; }
        public string Imagen { get; set; }
    }
}
