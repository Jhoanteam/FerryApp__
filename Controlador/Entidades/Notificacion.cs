using System;

namespace Ferriapp.Controlador.Entidades
{
    internal class Notificacion
    {
        public int IdNotificacion { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
