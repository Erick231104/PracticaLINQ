using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLINQ
{
    public partial class Form1 : Form
    {
        public Inventario inventario;
        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Categoria = txtCategoria.Text
            };

            inventario.AgregarProducto(producto);
            ActualizarListaProductos();
            MessageBox.Show("Producto Agregado correctamanete");
        }

        private void ActualizarListaProductos()
        {
            MostrarProductosEnLista(inventario.ObtenerProductos());
        }

        private void btnFiltrarPorCategoria_Click(object sender, EventArgs e)
        {
            var categoria = txtCategoriaFiltro.Text;
            var productosFiltrados = inventario.ObtenerPrecioProductoPorCategoria(categoria);
            MostrarProductosEnLista(productosFiltrados);
        }

        private void MostrarProductosEnLista(List<Producto> productos)
        {
            lstProductos.Items.Clear();
            foreach(var producto in productos)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void btnFiltrarPorPrecio_Click(object sender, EventArgs e)
        {
            decimal precioMinimo = decimal.Parse(txtPrecioFiltro.Text);
            var productosFiltrados = inventario.ObtenerPrecioProductoPorPrecio(precioMinimo);
            MostrarProductosEnLista(productosFiltrados);

        }
    }
}
