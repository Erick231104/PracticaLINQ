using System;

public class Animal
{
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Animal(string nombre, string especie, DateTime fechaNacimiento)
    {
        Nombre = nombre;
        Especie = especie;
        FechaNacimiento = fechaNacimiento;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Especie} ( Fecha de Nacimiento: {FechaNacimiento.ToLongDateString()})";
    }
}

