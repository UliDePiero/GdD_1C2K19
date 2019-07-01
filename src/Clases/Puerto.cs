using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class Puerto
    {
        public int id { get; set; }
        public string nombre { get; set; }      

        public Puerto(int _id, string _nombre)
        {
            this.id = _id;
            this.nombre = _nombre;       
        }
    }
}
