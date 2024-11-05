using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class Inventario
{
    private List<Producto> productos;

    public Inventario()
    {
        productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public List<Producto> ObtenerPrecioProductoPorCategoria(string categoria)
    {
        return productos.Where(p => p.Categoria == categoria).ToList();
    }

    public List<Producto> ObtenerPrecioProductoPorPrecio( decimal precioMinimo)
    {
        return productos.Where(p => p.Precio > precioMinimo).ToList();
    }

    public List<Producto> ObtenerProductos()
    {
        return productos;
    }

    public void ActualizarProducto(string nombreProducto, decimal nuevoPrecio, string nuevaCategoria )
    {
        var producto  = productos.FirstOrDefault(p => p.Nombre == nombreProducto);

        if (producto != null)
        {
            producto.Precio = nuevoPrecio;
            producto.Categoria = nuevaCategoria;
        }
        else
        {
            MessageBox.Show("Producto no encontrado");
        }
    }
}

