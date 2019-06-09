using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class EstadoCrucero
    {
        public int id { get; set; }
        public string descripcion { get; set; }        
        public DateTime fec_baja { get; set; }
        public DateTime fec_alta { get; set; }
        public Crucero crucero { get; set; }      

        public EstadoCrucero(int _id, string _descripcion, DateTime _fec_baja, DateTime _fec_alta, Crucero _crucero)
        {
            this.id = _id;
            this.descripcion = _descripcion;
            this.fec_baja = _fec_baja;
            this.fec_alta = _fec_alta;
            this.crucero = _crucero;
        }
    }
}
