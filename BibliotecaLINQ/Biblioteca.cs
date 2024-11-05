using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
public class Biblioteca
{
    public List<Libro> Libros { get; set; }
    public Dictionary<string, HashSet<Libro>> LibrosPorGenero { get; set; }

    public Biblioteca()
    {
        Libros = new List<Libro>();
        LibrosPorGenero = new Dictionary<string, HashSet<Libro>>();
    }

    //Metodo de agragar Libros
    public void AgregarLibro(Libro libro, string genero)
    {
        Libros.Add(libro);

        if(!LibrosPorGenero.ContainsKey(genero))
        {
            LibrosPorGenero[genero] = new HashSet<Libro>();
        }
        LibrosPorGenero[genero].Add(libro);
    }

    public List<Libro> BuscarLibrosPorAutor(string autor)
    {
        return Libros.Where(l => l.Autor.IndexOf(autor, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }

    //Metodo de coleccion de agragar libros con titulos latgos 
    public List<Libro> LibrosConTituloLargo (int longitudMinima)
    {
        return Libros.Where(l => l.Titulo.Length >= longitudMinima).ToList();
    }
    //Metodo de colecciones de agregar libro por año
    public List<Libro> LibrosPorAnio (int anio)
    {
        return Libros.Where(l => l.AnioPublicacion == anio).ToList();   
    }

    //Metodo de colecciones de Dictionary
    public Dictionary<string, int> ControlarLibrosPorGenero()
    {
        return LibrosPorGenero.ToDictionary(g => g.Key, g => g.Value.Count);
    }
}

