using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoVenta
    {
        private QueryVenta objcd_venta = new QueryVenta();

        public List<Venta> Listar()
        {
            return objcd_venta.Listar();
        }
    }
}
