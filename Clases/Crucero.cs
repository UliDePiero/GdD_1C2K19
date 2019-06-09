using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class Crucero
    {
        public int id { get; set; }
        public string identificador { get; set; }
        public MarcaCrucero marca { get; set; }
        public ModeloCrucero modelo { get; set; }
        public DateTime bajadef { get; set; }
        public int cabinas { get; set; }
        public List<Cabina> Cabinas;
        public List<ServicioCrucero> servicios;
        public List<EstadoCrucero> estados;
        private string p1;
        private object p2;
        private ModeloCrucero modeloCrucero;
        private List<Cabina> list1;
        private List<ServicioCrucero> list2;
        private decimal p3;
        private int p4;

        public Crucero(int _id, string _identificador, MarcaCrucero _marca, ModeloCrucero _modelo, int _cabinas)
        {
            this.id = _id;
            this.identificador = _identificador;
            this.marca = _marca;
            this.modelo = _modelo;            
            this.cabinas = _cabinas;
            this.Cabinas = new List<Cabina>();
            this.servicios = new List<ServicioCrucero>();
            this.estados = new List<EstadoCrucero>();
        }

        public Crucero(string _identificador,  MarcaCrucero _marca, ModeloCrucero _modelo, List<Cabina> _cabinas, List<ServicioCrucero> _servicios, int _cantCabinas)
        {
            this.identificador = _identificador;
            this.marca = _marca;
            this.modelo = _modelo;
            this.cabinas = _cantCabinas;
            this.servicios = _servicios;
            this.Cabinas = _cabinas;      
        }

    }
}
