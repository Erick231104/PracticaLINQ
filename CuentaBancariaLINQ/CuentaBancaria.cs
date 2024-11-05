using System;
using System.Collections.Generic;
public  class CuentaBancaria
{
    public string NumeroCuentta { get; set; }
    public double Saldo { get; set; }
    public List<Transaccion> Transacciones  { get; set; }

    public CuentaBancaria(string numeroCuentta, double saldo)
    {
        NumeroCuentta = numeroCuentta;
        Saldo = saldo;
        Transacciones = new List<Transaccion>();
    }

    //Metodo para depositar dinero
    public void Depositar(double monto)
    {
        Saldo += monto;
        Transacciones.Add(new Transaccion("Depositar", monto, DateTime.Now));
    }

    // Metodo paralla accion de retirar Dinero
    public bool Retirar(double monto)
    {
        if(Saldo >= monto)
        {
            Saldo -= monto;
            Transacciones.Add(new Transaccion("Retiro", monto, DateTime.Now));
            return true;
        }
        return false;
    }
 
    
}

