using System;
using ejemploDecorador.Interfaces;

namespace ejemploDecorador.Clases
{
    //Clase hambuerguesa
    public class Hamburguesa : IHamburguesa
    {
        public string getDescripcion()
        {
            return "Carne\nPan\n";
        }
    }
}
