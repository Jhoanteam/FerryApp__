using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoCliente
    {
        private QueryCliente objcd_cliente = new QueryCliente();

        public List<Cliente> Listar()
        {
            return objcd_cliente.Listar();
        }
    }
}
