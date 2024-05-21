using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Promocion
    {
        public int IdPromocion { get; set; }
        public string NombrePromocion { get; set; }
        public string CondicionesPromocion { get; set; }
        public double ValorDescuento { get; set; }
        public bool Disponible { get; set; }
    }
}
