using System;

public class Transaccion
{
    public string Tipo { get; set; }
    public double Monto { get; set; }
    public DateTime Fecha { get; set; }

    public Transaccion(string tipo, double monto, DateTime fecha)
    {
        Tipo = tipo;
        Monto = monto;
        Fecha = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Fecha}: {Tipo} de ${Monto}";
    }
}