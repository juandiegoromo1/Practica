using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Mascota
{
    internal class Mascota
    {
        private string nombre;
        private int niveldefelicidad;
        private int niveldeenergia;
        public Mascota(string nombre, int niveldefelicidad, int niveldeenergia)
        {
            this.nombre = nombre;
            this.niveldefelicidad = niveldefelicidad;
            this.niveldeenergia = niveldeenergia;
        }
        public void AlimentarMascotas(int cantidad)
        {
            niveldefelicidad += cantidad;
            niveldeenergia += cantidad;
            Console.WriteLine(nombre + " tiene ");
            Console.WriteLine("Nivel de Felicidad " + niveldefelicidad);
            Console.WriteLine("Nivel de Energia " + niveldeenergia);
        }
        public void JugarConMascota(int cantidad)
        {
            niveldefelicidad += cantidad;
            niveldeenergia -= cantidad;

            Console.WriteLine(nombre + " ha jugado.");
            Console.WriteLine("Nivel de Felicidad: " + niveldefelicidad);
            Console.WriteLine("Nivel de Energia: " + niveldeenergia);
        }
    }
   
}
