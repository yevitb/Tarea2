using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string apP;
            string apM;
            double tar;
            double part;
            double proy;

            Console.WriteLine("Alumnos a calificar ");
            int tam = Convert.ToInt32(Console.ReadLine());
            //int[] alumnos = new int[tam];
            Alumno[] alumnos = new Alumno[tam];
            for ( int i=0; i<alumnos.Length;i++)
            {
                Console.WriteLine("Nombre del alumno ");
                nom = Console.ReadLine();
                Console.WriteLine("Apellido paterno ");
                apP = Console.ReadLine();
                Console.WriteLine("Apellido materno ");
                apM = Console.ReadLine();
                Console.WriteLine("Proyecto: ");
                proy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tareas: ");
                tar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Participaciones: ");
                part = Convert.ToInt32(Console.ReadLine());
                
                alumnos[i] = new Alumno(nom,apP,apM,proy,tar,part);
                double prom = Calculadora.Promediar(alumnos[i].Proyectos, alumnos[i].Tareas, alumnos[i].Participaciones);
                alumnos[i].Imprimir(prom);
                Console.ReadKey();
            }
        }
    }
}
