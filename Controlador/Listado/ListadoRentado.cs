using Ferriapp.Controlador.conexionDB;
using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador.Listado
{
    internal class ListadoRentado
    {
        private QueryRentado objcd_rentado = new QueryRentado();

        public List<Rentado> Listar()
        {
            return objcd_rentado.Listar();
        }
    }
}
