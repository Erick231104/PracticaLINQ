using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class ZoologicoControlador
{
    private Zoologico _zoologico;


    public void AgregarExhibicion(string nombreExhibicion)
    {
      if( _zoologico == null)
      {
          _zoologico = new Zoologico();
      }
        _zoologico.AgregaqrExhibicion(new Exhibicion(nombreExhibicion));
    }

    public void AgregarAnimal(string nombreExhibicion,string nombreAnimal, string especie, DateTime fechaNacimiento)
    {
        var exhibicion = _zoologico.Exhibiciones.Find(e => e.Nombre == nombreExhibicion);
        if(exhibicion != null)
        {
            exhibicion.AgregarAniomal(new Animal(nombreAnimal, especie, fechaNacimiento));
        }

    }
    
    public List<Exhibicion> ObtenerExhibiciones()
    {
        return _zoologico.Exhibiciones;
    }

    public List<Animal> BuscarAnimalPorEspecie(string especie)
    {
        return _zoologico.BucarAnimalPorEspecie(especie);
    }
}

