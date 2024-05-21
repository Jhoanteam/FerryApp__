using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public string Nota { get; set; }
    }
}
