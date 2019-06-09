using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class TipoCabina
    {
        public int id { get; set; }
        public string nombre { get; set; }      
        public double porcentaje { get; set; }

        public TipoCabina(int _id, string _nombre, double _porcentaje)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.porcentaje = _porcentaje;            
        }
    }
}
