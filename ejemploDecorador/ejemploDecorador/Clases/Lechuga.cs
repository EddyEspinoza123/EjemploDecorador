using System;
using ejemploDecorador.Interfaces;

namespace ejemploDecorador.Clases
{
    //Clase lechuga descripcion de la Hamburguesa
    public class Lechuga : DecoradorHamburguesa
    {
        public Lechuga(IHamburguesa hamburguesa) : base(hamburguesa)
        {

        }

        public override string getDescripcion()
        {

            return this.hamburguesa.getDescripcion() + "Lechuga\n";
        }
    }
}
