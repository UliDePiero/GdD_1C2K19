using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class Reserva
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public DateTime fecha { get; set; }
        public int cliente { get; set; }
        public int crucero { get; set; }
        public int recorrido { get; set; }
        public int cabina { get; set; }

        public Reserva() { }

    }

}
