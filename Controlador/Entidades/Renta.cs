using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Renta
    {
        public int IdRenta { get; set; }
        public string Proveedor { get; set; }
        public string NombreRenta { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public double ValorxDia { get; set; }
        public double ValorxHora { get; set; }
        public string Imagen { get; set; }
        public bool Disponible { get; set; }
        public string Nota { get; set; }
    }
}
