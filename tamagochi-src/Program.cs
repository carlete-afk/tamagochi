using tamagochi_src;

public class Mascota
{
    public bool EstaHambriento { get; set; }
    byte humor;
    public byte Humor
    {
        get => humor;

        set
        {
            if (value > 100)
                humor = 100;

            else if (value < 0)
                humor = 0;
        }
    }
    
    public IEstado Estado { get; set; }
    public string nombre;

    public Mascota(string nombre)
    {
        this.nombre = nombre;
        this.EstaHambriento = true;
        this.Humor = 0;
        this.Estado = new Aburrido();
    }

    public void Comer()
        => Estado.Comer(this);

    public void Jugar()
        => Estado.Jugar(this);
    public void CambiarEstado(IEstado estado)
        => this.Estado = estado;

    public bool PuedeJugar()
        => Estado.PuedeJugar(this);
}

public class Program
{
    public static void Main()
    {
        
    }
}