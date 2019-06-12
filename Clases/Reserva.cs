﻿using System;
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
        public override int cabina { get; set; }

        public Reserva(int _viaje, int _cabina) 
        {
            viaje = _viaje;
            cabina = _cabina;
        }

        public override void finalizarTransaccion(int idCliente)
        {
            fecha = DateTime.Now;
            codigo = Reserva_DB.ultimoCodigoReserva();
            cliente = idCliente;

            EmitirReserva form = new EmitirReserva(codigo);
            form.Show();
        }
                            

    }

}
