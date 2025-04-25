using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Mascota
{
    internal class Juego
    {
        private Mascota mascota;
        public void Execute()
        {
            CrearMascota();

            while (true)
            {
                Console.WriteLine("\n¿Qué quieres hacer?");
                Console.WriteLine("1. Alimentar mascota");
                Console.WriteLine("2. Jugar con mascota");
                Console.WriteLine("3. Salir");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    AlimentarMascota();
                }
                else if (opcion == "2")
                {
                    JugarMascota();
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intenta otra vez.");
                }
            }
        }
        public void CrearMascota()
        {
            Console.WriteLine("Introduce el nombre de tu mascota");
            string nombre = (Console.ReadLine());
            Console.WriteLine("Introduce el nivel de felicidad de tu mascota");
            int niveldefelicidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el nivel de energia de tu mascota");
            int niveldeenergia = int.Parse(Console.ReadLine());
            mascota = new Mascota(nombre,niveldefelicidad,niveldeenergia);

        }
        public void AlimentarMascota()
        {
            Console.WriteLine("Introduce la Cantidad que alimentaras a tu mascota");
            int cantidad = int.Parse(Console.ReadLine());
            mascota.AlimentarMascotas(cantidad);
        }
        public void JugarMascota()
        {
            Console.WriteLine("Introduce la cantidad de juego con tu mascota:");
            int cantidad = int.Parse(Console.ReadLine());
            mascota.JugarConMascota(cantidad);
        }
    }
}
