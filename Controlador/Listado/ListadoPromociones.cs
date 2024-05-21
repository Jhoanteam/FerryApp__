using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoPromocion
    {
        private QueryPromociones queryPromociones = new QueryPromociones();

        public List<Promocion> Listar()
        {
            return queryPromociones.Listar();
        }
    }
}
