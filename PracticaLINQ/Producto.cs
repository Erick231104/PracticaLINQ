﻿public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }

    public override string ToString()
    {
        return $"{Nombre}, {Precio}, {Categoria}";
    }
}
