using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi_src
{
    public interface IEstado
    {
        public void Comer(Mascota mascota);
        public void Jugar(Mascota mascota);
        public bool PuedeJugar(Mascota mascota);
    }
}
