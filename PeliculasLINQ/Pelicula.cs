// Clase que representa una película con sus propiedades
public class Pelicula
{
    public string Titulo { get; set; }   // Título de la película
    public string Director { get; set; }  // Director de la película
    public string Genero { get; set; }    // Género de la película
    public int Anio { get; set; }         // Año de lanzamiento de la película

    // Constructor para inicializar los valores de una película
    public Pelicula(string titulo, string director, string genero, int anio)
    {
        Titulo = titulo;
        Director = director;
        Genero = genero;
        Anio = anio;
    }

    // Método para representar la película como una cadena
    public override string ToString()
    {
        return $"{Titulo} - Director: {Director}, Género: {Genero}, Año: {Anio}";
    }
}

