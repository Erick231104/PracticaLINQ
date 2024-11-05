using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoLINQ
{
    public partial class Form1 : Form
    {
        private List<Producto> productos;
        public Form1()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double precio = double.Parse(txtPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                string categoria = txtCategoria.Text;

                var producto = new Producto(nombre, precio, cantidad, categoria);
                productos.Add(producto);
                ActualizarListaProductos();
                LimpiarCampos();
            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor ingrese valores validos");
            }
        }

        private void ActualizarListaProductos()
        {
            lstProductos.Items.Clear();
            foreach(var producto in productos)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCategoria.Clear();
            txtLimiteBajoStock.Clear();
            txtFiltrarCategoria.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularValorInventario_Click(object sender, EventArgs e)
        {
            double totalValor = productos.Sum(p => p.Precio * p.Cantidad);
            MessageBox.Show($"Valor total del inventario: ${totalValor}");
        }

        private void btnProductosBajoStock_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = int.Parse(txtLimiteBajoStock.Text);
                var productosBajoStock = productos.Where(p => p.Cantidad < limite).ToList();
                MostrarProductos(productosBajoStock);
            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor ingrese el valor valido para el limite");
            }
        }

        private void MostrarProductos(List<Producto> productosLista)
        {
            lstProductos.Items.Clear();
            foreach (var producto in productosLista)
            {
                lstProductos.Items.Add(producto.ToString());
            }
        }

        private void btnFiltrarPorCategoria_Click(object sender, EventArgs e)
        {
            string Categoria = txtFiltrarCategoria.Text;
            var productosPorCategoria = productos.Where(p => p.Categoria.Equals(Categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            MostrarProductos(productosPorCategoria);
        }

        private void btnMostrarProductosMasCaros_Click(object sender, EventArgs e)
        {
            var productosMasCaros = productos.OrderByDescending(p => p.Precio).FirstOrDefault();
            if(productosMasCaros != null)
            {
                MessageBox.Show($"Producto mas caro: {productosMasCaros}");
            }
            else
            {
                MessageBox.Show("NO hay productos en la lista.");
            }
        }
    }
}
