using System;
using ejemploDecorador.Clases;
using ejemploDecorador.Interfaces;

namespace ejemploDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburguesa normal = new Hamburguesa();

            Lechuga hamburguesaConLechuga = new Lechuga(normal);

            Lechuga hamburguesaConDobleLechuga = new Lechuga(hamburguesaConLechuga);
            Tomate hamburguesaConTomate = new Tomate(hamburguesaConDobleLechuga);
            //Mostramos los Ingrediente de la Hamburguesa
            Console.WriteLine(hamburguesaConTomate.getDescripcion());
            Console.ReadKey();
        }        
    }
}
