using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionAutosApp
{
    // Clase que gestiona una colección de Autos
    public class GestionAuto
    {
        private List<Auto> autos; // Lista de autos

        // Constructor que inicializa la lista de autos
        public GestionAuto()
        {
            autos = new List<Auto>
            {
                // Añadiendo algunos autos de ejemplo
                new Auto("Toyota", "Corolla", 50000, 12000),
                new Auto("Honda", "Civic", 60000, 13000),
                new Auto("Ford", "F-150", 30000, 25000),
                new Auto("Chevrolet", "Spark", 40000, 8000),
                new Auto("Tesla", "Model S", 20000, 75000)
            };
        }

        // Método para obtener todos los autos
        public List<Auto> ObtenerAutos()
        {
            return autos; // Retorna la lista de autos
        }

        // Método para filtrar autos por kilometraje y precio
        public List<Auto> FiltrarAutos(double kilometrajeMin, double precioMax)
        {
            // Usa LINQ para filtrar los autos según las condiciones
            return autos
                .Where(a => a.Kilometraje >= kilometrajeMin && a.Precio <= precioMax)
                .ToList(); // Retorna la lista filtrada
        }

        // Método para obtener el auto más caro
        public Auto ObtenerAutoMasCaro()
        {
            return autos.OrderByDescending(a => a.Precio).FirstOrDefault(); // Retorna el auto más caro
        }

        // Método para contar autos por marca
        public Dictionary<string, int> ContarAutosPorMarca()
        {
            // Agrupa los autos por marca y cuenta cuántos hay por cada marca
            return autos.GroupBy(a => a.Marca)
                .ToDictionary(Auto => Auto.Key, Auto => Auto.Count()); // Retorna un diccionario de marcas y sus conteos
        }

        // Método para filtrar autos con bajo kilometraje
        public List<Auto> FiltrarAutosBajoKilometraje(double kilometrajeMax)
        {
            return autos.Where(a => a.Kilometraje < kilometrajeMax).ToList(); // Filtra autos por bajo kilometraje
        }
    }
}
