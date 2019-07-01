using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class RecorridoCrucero
    {
        public int id { get; set; }
        public int id_crucero { get; set; }
        public int id_recorido { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public RecorridoCrucero (int Reco_Cruc_id, int Reco_cruc_cruceroid, int Reco_cruc_Recoid, DateTime _fecha_Salida)
        {
            id = Reco_Cruc_id;
            id_crucero = Reco_cruc_cruceroid;
            id_recorido = Reco_cruc_Recoid;
            FechaSalida = FechaLlegada;
        }
    }
}
