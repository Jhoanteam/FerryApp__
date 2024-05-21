using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoProducto
    {
        private QueryStoc queryStoc = new QueryStoc();

        public List<Producto> Listar()
        {
            return queryStoc.Listar();
        }
    }
}
