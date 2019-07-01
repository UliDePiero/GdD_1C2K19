using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{

    public abstract class Datos
    {
        public abstract int id { get; set; }
        public abstract string codigo { get; set; }
        public abstract DateTime fecha { get; set; }
        public abstract int cliente { get; set; }
        public abstract int viaje { get; set; }
        public abstract List<int> cabina { get; set; }

        public abstract void finalizarTransaccion(int id, int cantidad);

    }


}
