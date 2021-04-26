using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_vehiculos_procedimiento
{
    struct Vehiculos
    {

        public int placa;
        public string color;
        public int ano;
        public string marca;
        public string modelo;
        public string propietario;
        static void Main(string[] args)
        {
            int cantidadMax;
            Console.WriteLine("Ingrese la cantidad maxima/total de vehiculos automotores");
            cantidadMax = int.Parse(Console.ReadLine());
            Vehiculos[] carros = new Vehiculos[cantidadMax];
            Console.WriteLine("\n");
            for (int i = 0; i < cantidadMax; i++)
            {
                Console.WriteLine("Ingrese la *marca* del vehiculo automotor");
                carros[i].marca = Console.ReadLine();
                Console.WriteLine("Ingrese *modelo* del vehiculo automotor");
                carros[i].modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el *color* del vehiculo automotor");
                carros[i].color = Console.ReadLine();
                Console.WriteLine("Ingrese el *año* del vehiculo automotor");
                carros[i].ano = int.Parse(Console.ReadLine());
                Console.WriteLine("NOTA°: Para el siguiente apartado, colocar unicamente los números, omitir letras y guiones...");
                Console.WriteLine("Ingrese el número° de *placa* del vehiculo automotor");
                carros[i].placa = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre del propietario");
                carros[i].propietario = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("La informacion de su/sus vehiculos automotores se procesó de la siguiente manera: ");
            Console.WriteLine("\n");
            for (int i = 0; i < cantidadMax; i++)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Marca: " + carros[i].marca);
                Console.WriteLine("Modelo: " + carros[i].modelo);
                Console.WriteLine("Color: " + carros[i].color);
                Console.WriteLine("Año: " + carros[i].ano);
                Console.WriteLine("Placa: " + carros[i].placa);
                Console.WriteLine("Propietario: " + carros[i].propietario);
                Console.WriteLine("**************************");

            }
            Console.ReadKey();
        }
    }
}
