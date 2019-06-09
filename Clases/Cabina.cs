using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class Cabina
    {
        private TipoCabina tCab;
        private int cruc_id;

        public int id { get; set; }
        public int piso { get; set; }      
        public int numero { get; set; }
        public TipoCabina tipo { get; set; }        
        public Crucero crucero { get; set; }

        public Cabina(int _id, int _piso, int _numero, TipoCabina _tipo, Crucero _crucero)
        {
            this.id = _id;
            this.piso = _piso;
            this.numero = _numero;
            this.tipo = _tipo;
            this.crucero = _crucero;
        }

        public Cabina(TipoCabina tCab, int cruc_id)
        {
            this.tCab = tCab;
            this.cruc_id = cruc_id;
        }
    }
}
