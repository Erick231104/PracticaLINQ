using System.Collections.Generic;
using System.Linq;

public class Zoologico
{
    public List<Exhibicion> Exhibiciones { get; private set; }

    public Zoologico()
    {
        Exhibiciones = new List<Exhibicion>();
    }

    public void AgregaqrExhibicion(Exhibicion exhibicion)
    {
        Exhibiciones.Add(exhibicion);
    }

    public List<Animal> BucarAnimalPorEspecie(string  especie)
    {
        return Exhibiciones.SelectMany(e => e.Animales).Where(a => a.Especie == especie).ToList();
    }
}

