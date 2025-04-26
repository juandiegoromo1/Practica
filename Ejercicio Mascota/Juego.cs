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
            while (true)
            {
                Console.WriteLine("¿Que quieres Hacer? ");
                Console.WriteLine("1. Crear mascota ");
                Console.WriteLine("2  Alimentar Mascota ");
                Console.WriteLine("3 Jugar Mascota ");
                Console.WriteLine("4 Salir ");
                
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: CrearMascota();break;
                    case 2: AlimentarMascota();break;
                    case 3: JugarMascota();break;
                    case 4: Salir();break;
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
        public void Salir()
        {
            Console.WriteLine(" Fin del Juego ");
        }
    }
}
