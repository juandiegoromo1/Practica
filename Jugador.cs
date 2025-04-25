using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Jugador
    {
        private int vida;
        private int dano;

        public Jugador (int vida, int dano)
        {
            this.vida = vida;
            this.dano = dano;
        }
        public void Recibirdano(int dano)
        {
            vida -= dano;
        }
        public int Hacerdano()
        {
            return (int)dano;
        }
        public bool VivoOmuerto()
        {
            return vida > 0;
        }
        public int Mostrarvida()
        {
            return vida;
        }
    }

}
