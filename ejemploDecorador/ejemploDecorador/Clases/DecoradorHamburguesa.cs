using System;
using ejemploDecorador.Interfaces;

namespace ejemploDecorador.Clases
{
    //Creamos clase para DecorarHamburguesa
    public abstract class DecoradorHamburguesa : IHamburguesa
    {
        protected IHamburguesa hamburguesa;

        public DecoradorHamburguesa(IHamburguesa hamburguesa) { this.hamburguesa = hamburguesa; }

        public abstract string getDescripcion();

    }
}
