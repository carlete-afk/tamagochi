using tamagochi_src;

namespace test_tamagochi
{
    public class Estados
    {
        Mascota mascota;
        public Estados() => mascota = new Mascota("Victor");
        [Fact]
        public void CrearMascotaOK()
        {
            Assert.IsType<Aburrido>(mascota.Estado);
        }

        [Fact]
        public void AburridoAContentoOK()
        {
            mascota.Estado = new Hambriento();
            mascota.Comer();
            Assert.IsType<Contento>(mascota.Estado);
        }
    }
}