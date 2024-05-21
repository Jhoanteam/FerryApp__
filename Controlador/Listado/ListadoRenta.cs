using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoRenta
    {
        private QueryRenta objcd_renta = new QueryRenta();

        public List<Renta> Listar()
        {
            return objcd_renta.Listar();
        }
    }
}
