using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi_src
{
    public class Contento : IEstado
    {
        byte Juegos = 0;

        public void Comer(Mascota mascota)
            => mascota.Humor++;

        public void Jugar(Mascota mascota)
        {
            if (Juegos < 5)
                mascota.CambiarEstado(new Hambriento());

            else
            {
                mascota.Humor += 2;
                Juegos++;
            }
        }

        public bool PuedeJugar(Mascota mascota)
            => true;
    }
}
