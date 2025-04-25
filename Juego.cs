using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Juego
    {
        private Jugador jugador;
        private Enemigo Enemigo;
        public bool findeljuego = false;

        public void Execute()
        {
            CrearJugador();
            CrearEnemigo();
            int opcion = 0;
            do
            {
                Console.WriteLine("1. Turno Jugador");
                Console.WriteLine("2. TurnoEnemigo");
                Console.WriteLine("3. Ver vida");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: TurnoJugador(); break;
                    case 2: TurnoEnemigo(); break;
                    case 3: Mostrarvida(); break;
                }

            } while (opcion != 4);
        }
        private void CrearEnemigo()
        {
            Console.WriteLine("Introduce la vida del Enemigo (maximo 100)");
            int vidaenemigo = int.Parse(Console.ReadLine());
            while (vidaenemigo > 100 || vidaenemigo <= 0)
            {
                Console.WriteLine("Introduce la vida del Enemigo (maximo 100)");
                vidaenemigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduce el daño del Enemigo (maximo 100)");
            int danoenemigo = int.Parse(Console.ReadLine());
            while (vidaenemigo > 100 || vidaenemigo <= 0)
            {
                Console.WriteLine("Introduce la vida del Enemigo (maximo 100)");
                danoenemigo = int.Parse(Console.ReadLine());
            }
            Enemigo = new Enemigo(vidaenemigo, danoenemigo);
        }
        public void CrearJugador()
        {
            Console.WriteLine("Introduce la vida del Jugador (maximo 100)");
            int vidajugador = int.Parse(Console.ReadLine());
            while (vidajugador > 100 || vidajugador <= 0)
            {
                Console.WriteLine("Introduce la vida del Jugador (maximo 100)");
                vidajugador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduce el daño del Jugador (maximo 100)");
            int danojugador = int.Parse(Console.ReadLine());
            while (danojugador > 100 || danojugador <= 0)
            {
                Console.WriteLine("Introduce la vida del Jugador (maximo 100)");
                danojugador = int.Parse(Console.ReadLine());
            }
            jugador = new Jugador(vidajugador, danojugador);
        }
        public void TurnoJugador()
        {
           Console.WriteLine("Atacaste al enemigo");
            if (Enemigo.VivoOmuerto() == false)
            {
                Console.WriteLine("El Jugador Ha sido Derrotado");
            }

            else
            {
                Console.WriteLine("Jugador Tu turno");
                Enemigo.Recibirdano(jugador.Hacerdano());
                if (Enemigo.VivoOmuerto() == false)
                {
                    Console.WriteLine("El Enemigo Ha sido Derrotado");
                  
                }
            }
        }
        public void TurnoEnemigo()
        {
            Console.WriteLine("Atacaste al jugador");
            if (Enemigo.VivoOmuerto() == false)
            {
                Console.WriteLine("El Enemigo Ha sido Derrotado");
            }

            else
            {
                Console.WriteLine("Enemigo Tu turno");
                jugador.Recibirdano(Enemigo.Hacerdano());
                if (jugador.VivoOmuerto() == false)
                {
                    Console.WriteLine("El Jugador Ha sido Derrotado");

                }
            }
        }
        private void Mostrarvida()
        {
            Console.WriteLine("Vida Jugador " + jugador.Mostrarvida());
            Console.WriteLine("Vida Enemigo " + Enemigo.Mostrarvida());
        }


    }
}
