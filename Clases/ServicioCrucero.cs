using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCrucero.Clases
{
    public class ServicioCrucero
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public List<Crucero> cruceros;

        public ServicioCrucero(int _id, string _descripcion)
        {
            this.id = _id;
            this.descripcion = _descripcion;
            this.cruceros = new List<Crucero>();
        }

        public ServicioCrucero(int _id, List<Crucero> _cruceros)
        {
            this.id = _id;
            this.cruceros = _cruceros;
        }
    }
}
