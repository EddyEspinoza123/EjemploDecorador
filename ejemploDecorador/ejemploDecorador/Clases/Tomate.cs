using System;
using ejemploDecorador.Interfaces;

namespace ejemploDecorador.Clases
{
    //Tomate Descripcion de la Hamburguesa
    public class Tomate : DecoradorHamburguesa
    {
        public Tomate(IHamburguesa hamburguesa) : base(hamburguesa)
        {

        }

        public override string getDescripcion()
        {
            return this.hamburguesa.getDescripcion() + "Tomate\n";
        }
    }
}
