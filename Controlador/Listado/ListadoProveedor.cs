using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoProveedor
    {
        private QueryProveedor objcd_proveedor = new QueryProveedor();

        public List<Proveedor> Listar()
        {
            return objcd_proveedor.Listar();
        }
    }
}
