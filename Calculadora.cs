using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    static class Calculadora
    {

        public static double Promediar(double proyectos, double tareas, double participaciones)
        {
            proyectos = proyectos * 0.6;
            tareas = tareas * 0.8;
            double promedio = (proyectos + tareas + participaciones)*10;
            if (promedio > 100)
                return 100;
            else if (promedio < 55)
                return 50;
            return promedio;
        }
    }
}
