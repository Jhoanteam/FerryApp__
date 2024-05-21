using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Venta
    {
        public int IdVenta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Productos { get; set; }
        public double ValorVenta { get; set; }
        public string Promocion { get; set; }
        public double ValorFinal { get; set; }
        public string Nota { get; set; }
        public bool Estado { get; set; }
    }
}
