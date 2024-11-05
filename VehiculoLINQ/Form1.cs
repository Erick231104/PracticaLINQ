using GestionAutosApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehiculoLINQ
{
    public partial class Form1 : Form
    {
        private GestionAuto gestionAutos;
        public Form1()
        {
            InitializeComponent();
            gestionAutos = new GestionAuto();//Crear una nueva instancia
        }

        private void btnAnalisisCompleto_Click(object sender, EventArgs e)
        {
            lstAutos.Items.Clear();// Limpia el LixBox del autos

            double KilometrajeMin;
            double PrecioMax;

            //Intenta convertie el texto a double para Kilometraje
            if(!double.TryParse(txtKilometrajeMinimo.Text, out KilometrajeMin))
            {
                KilometrajeMin = 0;
            }

            //Intenta convertir el texto de precio a double para precio
            if (!double.TryParse(txtPrecioMaximo.Text, out PrecioMax))
            {
                PrecioMax = double.MaxValue; //Asigna el valor por defecto
            }

            //Filtrar autos por kilometraje y precio
            var autosFiltrados = gestionAutos.FiltrarAutos(KilometrajeMin, PrecioMax);
            lstAutos.Items.Add("Aotos Filtrados:");
            foreach(var auto in autosFiltrados)
            {
                lstAutos.Items.Add(auto.ToString());
            }

            var autoMasCaro = gestionAutos.ObtenerAutoMasCaro();
            if(autoMasCaro != null)
            {
                lstAutos.Items.Add($"\nAuto más caro: {autoMasCaro}");// Muestra el auto mas caro
            }

            // Contar autos por marca
            var autosPorMarca = gestionAutos.ContarAutosPorMarca();
            lstAutos.Items.Add("\nCantidad de autos por marca:");
            foreach (var grupo in autosPorMarca)
            {
                lstAutos.Items.Add($"{grupo.Key}: {grupo.Value} autos"); // Muestra la cantidad de autos por marca
            }

            // Filtrar autos por bajo kilometraje
            var autosBajoKilometraje = gestionAutos.FiltrarAutosBajoKilometraje(30000);
            lstAutos.Items.Add("\nAutos con bajo kilometraje:");
            foreach (var auto in autosBajoKilometraje)
            {
                lstAutos.Items.Add(auto.ToString()); // Agrega autos de bajo kilometraje al ListBox
            }
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados por el usuario
            string marca = txtMarca.Text; // Marca del auto
            string modelo = txtModelo.Text; // Modelo del auto
            double kilometraje;
            double precio;

            // Validar y convertir el kilometraje
            if (!double.TryParse(txtKilometrajeMinimo.Text, out kilometraje))
            {
                MessageBox.Show("Por favor ingresa un kilometraje válido."); // Mensaje de error
                return; // Salir si hay error
            }

            // Validar y convertir el precio
            if (!double.TryParse(txtPrecioMaximo.Text, out precio))
            {
                MessageBox.Show("Por favor ingresa un precio válido."); // Mensaje de error
                return; // Salir si hay error
            }

            // Crear un nuevo auto y agregarlo a la gestión
            Auto nuevoAuto = new Auto(marca, modelo, kilometraje, precio);
            gestionAutos.ObtenerAutos().Add(nuevoAuto); // Agrega el nuevo auto a la lista

            // Limpiar los campos de entrada
            txtMarca.Clear();
            txtModelo.Clear();
            txtKilometrajeMinimo.Clear();
            txtPrecioMaximo.Clear();

            // Actualizar la lista de autos mostrada
            ActualizarListaAutos();
        }

        // Método para actualizar la lista de autos mostrada en el ListBox
        private void ActualizarListaAutos()
        {
            lstAutos.Items.Clear(); // Limpia el ListBox
            foreach (var auto in gestionAutos.ObtenerAutos())
            {
                lstAutos.Items.Add(auto.ToString()); // Agrega cada auto a la lista
            }
        }
    }
}
