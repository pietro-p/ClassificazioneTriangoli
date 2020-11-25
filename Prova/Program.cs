using metodi;
using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double n1 = Metodo.InserisciLato();
            double n2 = Metodo.InserisciLato();
            double n3 = Metodo.InserisciLato();
            Metodo.Classificazione(n1, n2, n3);
            Console.WriteLine($"Il suo perimetro è {Metodo.Perimetro(n1, n2, n3)}");
        }
    }
}
