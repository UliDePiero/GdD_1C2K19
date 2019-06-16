using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.BD_y_Querys;
using FrbaCrucero.CompraReservaPasaje;

namespace FrbaCrucero.Clases
{
    public class Pasaje : Datos
    {
        public override int id { get; set; }
        public override string codigo { get; set; }
        public override DateTime fecha { get; set; }
        public override int cliente { get; set; }
        public override int viaje { get; set; }
        public override List<int> cabina { get; set; }
        public float precio { get; set; }
        public int unaCabina;

        public Pasaje(int _viaje, List<int> _cabina, float _precio) 
        {
            viaje = _viaje;
            cabina = _cabina;
            precio = _precio;
        }
        public Pasaje(int _cliente, int _viaje,float _precio)
        {
            fecha = DateTime.Now;
            cabina = new List<int>();
            cliente = _cliente;
            viaje = _viaje;
            precio = _precio;
        }

        public override void finalizarTransaccion(int idCliente, int cantidad)
        {
            fecha = DateTime.Now;
            codigo = Reserva_DB.ultimoCodigoPasaje();
            cliente = idCliente;

            Reserva_DB.guardarCompra(this);

            EmitirPago form = new EmitirPago(codigo);
            form.Show();
        }
    }
}
