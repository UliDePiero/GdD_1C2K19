﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    public class ROL
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool habilitado { get; set; }
        public List<Funcionalidad> funcionalidades;

        public ROL(int _id, string _nombre, bool _habilitado)
        {
            this.id = _id;
            this.nombre = _nombre;
            this.habilitado = _habilitado;
            this.funcionalidades = new List<Funcionalidad>();
        }

        public ROL(string _nombre, List<Funcionalidad> _funcionalidades)
        {
            this.nombre = _nombre;
            this.funcionalidades = _funcionalidades;
        }
    }
}
