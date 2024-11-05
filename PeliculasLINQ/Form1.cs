using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasLINQ
{
    public partial class Form1 : Form
    {
        private GestionPeliculas gestionPeliculas; // Instancia de la clase GestionPeliculas
        public Form1()
        {
            InitializeComponent();
            gestionPeliculas = new GestionPeliculas(); // Crea una nueva instancia de la gestión de películas
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            // Captura los datos ingresados en los TextBox
            string titulo = txtTitulo.Text;
            string director = txtDirector.Text;
            string genero = txtGenero.Text;
            int anio;

            // Intenta convertir el año a un entero; si falla, muestra un mensaje de error
            if (!int.TryParse(txtAnio.Text, out anio))
            {
                MessageBox.Show("Ingrese un año válido.");
                return; // Salir del método si el año no es válido
            }

            // Crea una nueva película con los datos ingresados
            Pelicula nuevaPelicula = new Pelicula(titulo, director, genero, anio);
            gestionPeliculas.AgregarPelicula(nuevaPelicula); // Agrega la película a la lista
            ActualizarListaPeliculas(); // Actualiza la lista mostrada en el ListBox
            LimpiarCampos(); // Limpia los campos de entrada
        
        }

        // Método para actualizar la lista de películas en el ListBox
        private void ActualizarListaPeliculas()
        {
            lstpeliculas.Items.Clear(); // Limpia el ListBox antes de mostrar las películas
            foreach (var pelicula in gestionPeliculas.ObtenerTodasLasPeliculas())
            {
                lstpeliculas.Items.Add(pelicula.ToString()); // Agrega cada película al ListBox
            }
        }

        // Método para limpiar los campos de entrada
        private void LimpiarCampos()
        {
            txtTitulo.Clear(); // Limpia el campo de título
            txtDirector.Clear(); // Limpia el campo de director
            txtGenero.Clear(); // Limpia el campo de género
            txtAnio.Clear(); // Limpia el campo de año
            txtDirectorFiltrado.Clear(); // Limpia el campo de filtro por director
            txtGeberoFiltrado.Clear(); // Limpia el campo de filtro por género
        }

        // Método para mostrar las películas filtradas en el ListBox
        private void MostrarPeliculas(List<Pelicula> peliculas)
        {
            lstpeliculas.Items.Clear(); // Limpia el ListBox antes de mostrar las películas
            if (peliculas.Count > 0) // Si hay películas filtradas
            {
                foreach (var pelicula in peliculas)
                {
                    lstpeliculas.Items.Add(pelicula.ToString()); // Agrega cada película al ListBox
                }
            }
            else
            {
                lstpeliculas.Items.Add("No se encontraron películas."); // Mensaje si no hay resultados
            }
        }

        private void btnFiltrarPordirector_Click(object sender, EventArgs e)
        {
            string director = txtDirectorFiltrado.Text; // Captura el director ingresado
            var peliculasFiltradas = gestionPeliculas.FiltrarPorDirector(director); // Filtra las películas
            MostrarPeliculas(peliculasFiltradas); // Muestra las películas filtradas
        }

        private void btnFiltrarPorGenero_Click(object sender, EventArgs e)
        {
            string genero = txtGeberoFiltrado.Text; // Captura el género ingresado
            var peliculasFiltradas = gestionPeliculas.FiltrarPorGenero(genero); // Filtra las películas
            MostrarPeliculas(peliculasFiltradas); // Muestra las películas filtradas
        }

        private void btnMostrarPromedioAnios_Click(object sender, EventArgs e)
        {
            double promedioAnio = gestionPeliculas.ObtenerPromedioAnios(); // Obtiene el promedio de años
            MessageBox.Show($"El promedio de años de lanzamiento es: {promedioAnio}"); // Muestra el promedio
        }
    }
}
