using System.Collections.Generic; // Importar espacio de nombres para trabajar con listas
using System.Linq;

// Clase que gestiona una colección de películas
public class GestionPeliculas
{
    private List<Pelicula> _peliculas; // Lista interna que almacena las películas

    // Constructor que inicializa la lista de películas
    public GestionPeliculas()
    {
        _peliculas = new List<Pelicula>();
    }

    // Método para agregar una nueva película a la lista
    public void AgregarPelicula(Pelicula pelicula)
    {
        _peliculas.Add(pelicula);
    }

    // Método para filtrar películas por director
    public List<Pelicula> FiltrarPorDirector(string director)
    {
        // Retorna una lista de películas cuyo director contiene el texto proporcionado
        return _peliculas.FindAll(p => p.Director.IndexOf(director, System.StringComparison.OrdinalIgnoreCase) >= 0);
    }

    // Método para filtrar películas por género
    public List<Pelicula> FiltrarPorGenero(string genero)
    {
        // Retorna una lista de películas que coinciden con el género proporcionado
        return _peliculas.FindAll(p => p.Genero.Equals(genero, System.StringComparison.OrdinalIgnoreCase));
    }

    // Método para obtener el promedio de años de lanzamiento de las películas
    public double ObtenerPromedioAnios()
    {
        // Calcula y retorna el promedio de los años de lanzamiento; si no hay películas, retorna 0
        return _peliculas.Count > 0 ? _peliculas.Average(p => p.Anio) : 0;
    }

    // Método para obtener todas las películas
    public List<Pelicula> ObtenerTodasLasPeliculas()
    {
        return _peliculas; // Retorna la lista completa de películas
    }
}

