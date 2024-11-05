using System.Collections.Generic;

public class Exhibicion
{
    public string Nombre { get; set; }
    public List<Animal> Animales { get; set; }

    public Exhibicion(string nombre)
    {
        Nombre = nombre;
        Animales = new List<Animal>();
    }

    public void AgregarAniomal(Animal animal)
    {
        Animales.Add(animal);
    }

    public override string ToString()
    {
        return $" {Nombre} - {Animales.Count} Animales";
    }
}

