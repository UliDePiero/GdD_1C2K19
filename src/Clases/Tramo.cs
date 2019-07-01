using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class Tramo
    {
 
        public int id { get; set; }
        public decimal precio { get; set; }
        public decimal duracion { get; set; }
        public Puerto origen { get; set; }
        public Puerto destino { get; set; }

        public Tramo(int _id, decimal _precio, decimal _duracion, Puerto _origen, Puerto _destino)
        {
            this.id = _id;
            this.precio = _precio;
            this.duracion = _duracion;
            this.origen = _origen;
            this.destino = _destino;
        }

        public Tramo(decimal _precio, decimal _duracion, Puerto _origen, Puerto _destino)
        {
            this.precio = _precio;
            this.duracion = _duracion;
            this.origen = _origen;
            this.destino = _destino;
        }
    }
}
