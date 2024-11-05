using System;
using System.Collections.Generic;
public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }

    public Libro(string titulo, string autor, int anioPublicacion)
    {
        Titulo = titulo;
        Autor = autor;
        AnioPublicacion = anioPublicacion;
    }

    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({AnioPublicacion})";
    }
}

