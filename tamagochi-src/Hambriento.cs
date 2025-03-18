namespace tamagochi_src;

public class Hambriento : IEstado
{
    public void Comer(Mascota mascota)
        => mascota.CambiarEstado(new Contento());
        
    public void Jugar(Mascota mascota)
        => mascota.EstaHambriento = false;

    public bool PuedeJugar(Mascota mascota)
        => false;
}
