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
        public int viaje { get; set; }
        public int cabina { get; set; }

        public Reserva(string _codigo,int _viaje, int _cabina) 
        {
            codigo = _codigo;
            fecha = DateTime.Now;
            viaje = _viaje;
            cabina = _cabina;
        }

    }

}
