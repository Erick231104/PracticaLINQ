using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLINQ
{
    public partial class Form1 : Form
    {
        private BibliotecaControlador _bibliotecaControlador;
        public Form1()
        {
            InitializeComponent();
            //Crear una instancia de Biblioteca para pasarla al controlador
            var biblioteca = new Biblioteca(); //Asegurate de tener la clase Biblioteca
            _bibliotecaControlador = new BibliotecaControlador(biblioteca);
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int anioPublicacion = int.Parse(txtAnio.Text);
            string genero = txtGenero.Text;

            if(int.TryParse(txtAnio.Text, out anioPublicacion) && !string.IsNullOrWhiteSpace(genero))
            {
                var nuevoLibro = new Libro(titulo, autor, anioPublicacion);
                _bibliotecaControlador.ObtenrBiblioteca().AgregarLibro(nuevoLibro, genero);
                lstLibros.Items.Add(nuevoLibro);
                txtTitulo.Clear();
                txtAutor.Clear();
                txtAnio.Clear();
                txtGenero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, Ingresa todos los detalles del libro");
            }
        }

        private void btnBuscarPorAutor_Click(object sender, EventArgs e)
        {
            string autor = txtAutor.Text;
            lstLibros.Items.Clear();
            var librosPorAutor = _bibliotecaControlador.ObtenrBiblioteca().BuscarLibrosPorAutor(autor);
            foreach( var libro in librosPorAutor )
            {
                lstLibros.Items.Add(libro);
            }
        }

        private void btnLibrosConTitulosLargos_Click(object sender, EventArgs e)
        {
            lstLibros.Items.Clear();
            var librosPorTitulosLargos = _bibliotecaControlador.ObtenrBiblioteca().LibrosConTituloLargo(10);
            foreach (var libro in librosPorTitulosLargos)
            {
                lstLibros.Items.Add(libro);
            }
        }

        private void btnControlarLibrosPorGenero_Click(object sender, EventArgs e)
        {
            lstLibros.Items.Clear();
            var contarLibrosPorgtenero = _bibliotecaControlador.ObtenrBiblioteca().ControlarLibrosPorGenero();
            foreach (var libro in contarLibrosPorgtenero)
            {
                lstLibros.Items.Add($"{libro.Key}: {libro.Value} libros");
            }
        }
    }
}
