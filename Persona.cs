using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Persona
    {
        public string Nombre { get; set; }
        protected string ApellidoPat { get; set; }
        protected string ApellidoMat { get; set; }
        public Persona() { }
        public Persona(string nombre, string apellidoPat, string apellidoMat)
        {
            Nombre = nombre;
            ApellidoPat = apellidoPat;
            ApellidoMat = apellidoMat;
        }
        public override string ToString()
        {
            return string.Format(" Alumno {0} {1} {2}", Nombre, ApellidoPat, ApellidoMat);
            
        }
    }
}
