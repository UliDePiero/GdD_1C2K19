using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.BD_y_Querys;

namespace FrbaCrucero.Clases
{
    public class Reserva : Datos
    {

        public override int id { get; set; }
        public override string codigo { get; set; }
        public override DateTime fecha { get; set; }
        public override int cliente { get; set; }
        public override int viaje { get; set; }
        public override List<int> cabina { get; set; }
        public int unaCabina { get; set; }

        public Reserva(int _viaje, List<int> _cabina) 
        {
            viaje = _viaje;
            cabina = _cabina;
            fecha = DateTime.Now;
        }

        public Reserva(int _id, int _cliente, int _viaje, int _cabina)
        {
            this.id = _id;
            this.viaje = _viaje;
            this.cliente = _cliente;
            this.unaCabina = _cabina;
        }

        public override void finalizarTransaccion(int idCliente, int cantidad)
        {
            codigo = Reserva_DB.ultimoCodigoReserva();
            cliente = idCliente;


                Reserva_DB.guardar(this);

            EmitirReserva form = new EmitirReserva(codigo);
            form.Show();
        }
                            

    }

}
