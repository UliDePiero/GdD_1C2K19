using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Clases
{
    class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string mail { get; set; }
        public string documento { get; set; }
        public string fechaNacimiento { get; set; }
        public EstadoUsuario Estado { get; set; }

        public Usuario(string _nombre, string _apellido, string _telefono, string _direccion, string _mail, string _documento, string _fechaNac)
        {
            nombre = _nombre;
            apellido = _apellido;
            telefono = _telefono;
            direccion = _direccion;
            mail = _mail;
            documento = _documento;
            fechaNacimiento = _fechaNac;
        }
    }
}
