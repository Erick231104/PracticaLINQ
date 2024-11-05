using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaBancariaLINQ
{
    public partial class Form1 : Form
    {
        private CuentaBancaria _cuenta;

        public Form1()
        {
            InitializeComponent();
            _cuenta = new CuentaBancaria("123_-456-789", 500.000);
        }

        private void btnDepositrar_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            _cuenta.Depositar(monto);
            ActualizarSaldo();
            ActualizarTransacciones();
        }

        private void ActualizarTransacciones()
        {
            lstTransacciones.Items.Clear();
            foreach(var transaccion in _cuenta.Transacciones)
            {
                lstTransacciones.Items.Add(transaccion.ToString());
            }
        }

        private void ActualizarSaldo()
        {
           lblSaldo.Text = $"saldo: {_cuenta.Saldo}";
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            bool exito = _cuenta.Retirar(monto);

            if (exito)
            {
                ActualizarSaldo();
                ActualizarTransacciones();
            }
            else
            {
                MessageBox.Show("Fondos insificientes para realizar el retiro.");
            }
        }

        private void btnMostrarTransaccionesRecientes_Click(object sender, EventArgs e)
        {
            lstTransacciones.Items.Clear();
            var transaccionesRecientes = _cuenta.Transacciones.OrderByDescending(t => t.Fecha)
                .Take(10).ToList();

            foreach(var transaccion in transaccionesRecientes)
            {
                lstTransacciones.Items.Add(transaccion.ToString());
            }
        }

        private void btnMostrarPromedioTransacciones_Click(object sender, EventArgs e)
        {
            double promedio = _cuenta.Transacciones.Average(t => t.Monto);
            MessageBox.Show($"El pormedio de las transacciones es: {promedio}");
        }

        private void FiltrarTransaccionesAltas_Click(object sender, EventArgs e)
        {
            var transaccionesAltas = _cuenta.Transacciones.Where(t => t.Monto > 100).ToList();
            lstTransacciones.Items.Clear();
            foreach(var transaccion in transaccionesAltas)
            {
                lstTransacciones.Items.Add(transaccion.ToString());
            }
        }
    }
}
