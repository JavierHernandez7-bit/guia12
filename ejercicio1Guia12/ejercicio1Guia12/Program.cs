using System;

namespace ejercicio1Guia12
{
    class Program
    {
        struct programa
        {
            public String universidad;
            public String carrera;
        }
        struct estudiante
        {
            public String nombre;
            public int edad;
            public programa estudios;
        }
        static void Main(string[] args)
        {
            Console.Title = "Ejemplo3 de estructuras anidadas";
            estudiante estudiante = new estudiante();
            Console.WriteLine("Ingrese el nombre:");
            estudiante.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Edad: ");
            estudiante.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la carrera en estudio:");
            estudiante.estudios.carrera = Console.ReadLine();
            Console.WriteLine("Ingrese la Universidad");
            estudiante.estudios.universidad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("MOSTRANDO DATOS PROCESADOS....");
            Console.WriteLine("Estudiante: " + estudiante.nombre);
            Console.WriteLine("Edad: " + estudiante.edad);
            Console.WriteLine("Carrera: " + estudiante.estudios.carrera);
            Console.WriteLine("Universidad: " + estudiante.estudios.universidad);
            Console.ReadKey();
        }   
    }
}
