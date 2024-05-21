using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoCompra
    {
        private QueryCompra objcd_compra = new QueryCompra();

        public List<Compra> Listar()
        {
            return objcd_compra.Listar();
        }
    }
}
