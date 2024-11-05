public class Estudiante
{
    public string Nombre { get; set; }
    public string Id { get; set; }
    public double Promedio { get; set; }

    public Estudiante(string nombre, string id, double promedio)
    {
        Nombre = nombre;
        Id = id;
        Promedio = promedio;
    }
}

