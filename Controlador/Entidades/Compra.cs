using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Compra
    {
        public int IdCompra { get; set; }
        public string Usuario { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public double ValorCompra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nota { get; set; }
        public bool Estado { get; set; } 
    }
}
