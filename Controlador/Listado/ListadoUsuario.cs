using Ferriapp.Controlador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferriapp.Controlador
{
    internal class ListadoUsuario
    {
        private QueryUsuario objcd_usuario = new QueryUsuario();
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
