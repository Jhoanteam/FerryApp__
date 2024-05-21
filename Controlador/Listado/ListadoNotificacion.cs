using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;

namespace Ferriapp.Controlador
{
    internal class ListadoNotificacion
    {
        private QueryNotificacion queryNotificacion;

        public List<Notificacion> Listar()
        {
            return queryNotificacion.Listar();
        }
    }
}
