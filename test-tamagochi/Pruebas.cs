using tamagochi_src;

namespace test_tamagochi
{
    public class Pruebas
    {
        Mascota mascota;
        public Pruebas()
            => mascota = new Mascota("Victor");

        [Fact]
        public void CrearMascotaOK()
        {
            Assert.IsType<Aburrido>(mascota.Estado);
        }

        [Fact]
        public void HambrientoAContentoComiendoOK()
        {
            mascota.Estado = new Hambriento();
            mascota.Comer();
            
            Assert.IsType<Contento>(mascota.Estado);
        }

        [Fact]
        public void ContentoAHambrientoJugandoOK()
        {
            mascota.Estado = new Contento();
            
            for (int i = 0; i < 6; i++)
                mascota.Jugar();

            Assert.IsType<Hambriento>(mascota.Estado);
        }

        [Fact]
        public void AburridoAContentoJugandoOK()
        {
            mascota.Estado = new Aburrido();
            mascota.Jugar();

            Assert.IsType<Contento>(mascota.Estado);
        }

        [Fact]
        public void MaxHumorOK()
        {
            mascota.Humor = 120;
            Assert.Equal(100, mascota.Humor);
        }

        [Fact]
        public void PuedeJugarOK()
        {
            mascota.CambiarEstado(new Contento());
            Assert.True(mascota.PuedeJugar());

            mascota.CambiarEstado(new Hambriento());
            Assert.False(mascota.PuedeJugar());

            mascota.CambiarEstado(new Aburrido());
            Assert.True(mascota.PuedeJugar());
        }
    }
}