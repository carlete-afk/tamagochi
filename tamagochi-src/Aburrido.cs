using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi_src
{
    public class Aburrido : IEstado
    {
        DateTime aburridoDesde;
        TimeSpan tiempoAburrido;

        public Aburrido()
        {
            this.aburridoDesde = DateTime.Now;
        }

        public void Comer(Mascota mascota)
        {
            tiempoAburrido = DateTime.Now - aburridoDesde;

            if (tiempoAburrido.TotalMinutes > 80)
                mascota.CambiarEstado(new Contento());

            else
                mascota.Humor -= 5;
        }

        public void Jugar(Mascota mascota)
            => mascota.CambiarEstado(new Contento());

        public bool PuedeJugar(Mascota mascota)
            => true;
    }
}
