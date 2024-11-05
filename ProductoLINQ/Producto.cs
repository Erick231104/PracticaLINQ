public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
    public string Categoria { get; set; }

    public Producto(string nombre, double precio, int cantidad, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
        Categoria = categoria;
    }

    public override string ToString()
    {
        return $"{Nombre} (Categoria. {Categoria}), precio: ${Precio}, cantidad: {Cantidad}";
    }
}

