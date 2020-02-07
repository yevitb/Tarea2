using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno : Persona
    {
        double proyectos;
        double participaciones;
        double tareas;
        double promedio;
        public Alumno(string nombre, string apellidoPat, string apellidoMat) : base(nombre, apellidoPat, apellidoMat) { }
        public double Proyectos
        {
            get { return proyectos; }
            set
            {
                if (value < 5)
                    proyectos = (5);
                else if (value > 10)
                    proyectos = (10);
                else
                    proyectos = (value);
            }
        }
        public double Tareas
        {
            get { return tareas; }
            set
            {  tareas = (value); }
        }
        public double Participaciones {
            get { return participaciones; }
            set
            {
                if (value > 5)
                    participaciones = 0.8;
                else
                    participaciones = 0;
            }
        }
        public double Promedio
        {
            set { promedio = proyectos + tareas + participaciones; }
            get { return promedio; }
            
        }

        public Alumno(string nombre, string apellidoPat, string apellidoMat,double proyectos,double tareas, double participaciones):base(nombre, apellidoPat, apellidoMat)
        {
            Proyectos = proyectos;
            Tareas = tareas;
            Participaciones = participaciones;

        }
        public void Imprimir(double promedio) 
        {
            Console.WriteLine("El alumno {0} {1} {2} obtuvo {3} ",Nombre,ApellidoPat,ApellidoMat,promedio);
        }
    }
}
