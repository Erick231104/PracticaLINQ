public class BibliotecaControlador
{
    private Biblioteca _biblioteca;

  
    public BibliotecaControlador(Biblioteca biblioteca)
    {
        _biblioteca = new Biblioteca();
    }

    public Biblioteca ObtenrBiblioteca()
    {
        return _biblioteca;
    }
}

