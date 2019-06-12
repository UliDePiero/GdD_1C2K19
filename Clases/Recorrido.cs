using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class Recorrido
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public Tramo primerTramo { get; set; }
        public List<Tramo> tramosSiguientes;
        public List<Tramo> tramos;

        public Recorrido(int _id, string _codigo, Tramo _primerTramo)
        {
            this.id = _id;
            this.codigo = _codigo;
            this.primerTramo = _primerTramo;
            this.tramosSiguientes = new List<Tramo>();
            this.tramos = new List<Tramo>();
        }

        public Recorrido(string _codigo, Tramo _primerTramo)
        {            
            this.codigo = _codigo;
            this.primerTramo = _primerTramo;
            this.tramosSiguientes = new List<Tramo>();
            this.tramos = new List<Tramo>();
        }
    }
}
