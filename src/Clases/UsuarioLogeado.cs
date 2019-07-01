using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    static class UsuarioLogeado
    {                
        private static string usuario = "";

        public static string Username
        {
            get { return usuario; }
            set { usuario = value; }
        }        
    }
}
