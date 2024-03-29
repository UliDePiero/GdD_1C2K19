﻿using System;
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

        public Crucero(string identificadorCrucero, MarcaCrucero marcaCrucero, ModeloCrucero modeloCrucero, List<ServicioCrucero> serviciosCrucero)
        {
            this.identificador = identificadorCrucero;
            this.marca = marcaCrucero;
            this.modelo = modeloCrucero;
            this.servicios = serviciosCrucero;
        }

        public Crucero(string _identificador,  MarcaCrucero _marca, ModeloCrucero _modelo, List<Cabina> _cabinas, List<ServicioCrucero> _servicios)
        {
            this.identificador = _identificador;
            this.marca = _marca;
            this.modelo = _modelo;
            this.Cabinas = _cabinas;
            this.servicios = _servicios;  
        }

        public Crucero(int id1, string identificador1)
        {
            this.id = id1;
            this.identificador = identificador1;
        }

    }
}
