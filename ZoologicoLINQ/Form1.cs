using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoologicoLINQ
{
    public partial class Form1 : Form
    {
        private ZoologicoControlador _controlador;
        public Form1()
        {
            InitializeComponent();
            _controlador = new ZoologicoControlador();
            InicializarDatos();
        }

        private void InicializarDatos()
        {
            // Agregar algunas exhibiciones y animales iniciales
            _controlador.AgregarExhibicion("Selva Tropical");
            _controlador.AgregarExhibicion("Sabana Africana");

            _controlador.AgregarAnimal("Selva Tropical", "Tigre", "Felino", new DateTime(2015, 6, 12));
            _controlador.AgregarAnimal("Selva Tropical", "Mono", "Primate", new DateTime(2018, 2, 23));
            _controlador.AgregarAnimal("Sabana Africana", "León", "Felino", new DateTime(2016, 11, 5));

            ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            lstAnimales.Items.Clear();
            foreach (var exhibicion in _controlador.ObtenerExhibiciones())
            {
                lstAnimales.Items.Add(exhibicion);
                foreach (var animal in exhibicion.Animales)
                {
                    lstAnimales.Items.Add("   " + animal);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarExhibicion_Click(object sender, EventArgs e)
        {
            string nombreExhibicion = txtNombreExibicion.Text;
            _controlador.AgregarExhibicion(nombreExhibicion);
            ActualizarListBox();
        }

        private void btbAgregarAnimasl_Click(object sender, EventArgs e)
        {
            string nombreExhibicion = txtNombreExibicion.Text;
            string nombreAnimal = txtNombreAnimal.Text;
            string especie = txtEspecie.Text;
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value;

            _controlador.AgregarAnimal(nombreExhibicion, nombreAnimal, especie, fechaNacimiento);
            ActualizarListBox();
        }

        private void btnBuscarPorEspecie_Click(object sender, EventArgs e)
        {
            string especie = txtBuscarEspecie.Text;
            var animales = _controlador.BuscarAnimalPorEspecie(especie);

            lstAnimales.Items.Clear();
            foreach (var animal in animales)
            {
                lstAnimales.Items.Add(animal);
            }
        }
    }
}
