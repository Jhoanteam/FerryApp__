using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Entidades
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Documento { get; set; }
        public string Domicilio { get; set; }
        public string Contraseña { get; set; }
        public int IdUser { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Disponible { get; set; }
        public string Nota { get; set; }
    }
}
