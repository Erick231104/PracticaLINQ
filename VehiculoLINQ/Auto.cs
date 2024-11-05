using System;

namespace GestionAutosApp
{
    // Clase que define la estructura de un Auto
    public class Auto
    {
        // Propiedades del auto
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Kilometraje { get; set; }
        public double Precio { get; set; }

        // Constructor para inicializar un nuevo Auto
        public Auto(string marca, string modelo, double kilometraje, double precio)
        {
            Marca = marca;           // Asigna la marca
            Modelo = modelo;         // Asigna el modelo
            Kilometraje = kilometraje; // Asigna el kilometraje
            Precio = precio;         // Asigna el precio
        }

        // Método para representar el Auto como cadena
        public override string ToString()
        {
            return $"{Marca} {Modelo} - Km: {Kilometraje}, Precio: ${Precio}";
        }
    }
}
