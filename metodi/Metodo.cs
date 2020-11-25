using System;

namespace metodi
{
    public class Metodo

    {
        public static double InserisciLato()
        {
            double n;
            do
            {
                Console.WriteLine("inserisci un lato: ");
                n = Convert.ToDouble(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        public static void Classificazione(double n1, double n2, double n3)
        {
            if (n1 != n2 && n1 != n3 && n2 != n3)
            {
                Console.WriteLine("Triangolo Scaleno");
            }
            else if (n1 != n2 || n1 != n3 || n2 != n3)
            {
                Console.WriteLine("Triangolo Isoscele");
            }
            else if (n1 == n2 && n1 == n3 && n2 == n3)
            {
                Console.WriteLine("Triangolo Equilatero");
            }
        }
        public static double Perimetro(double n1, double n2, double n3)
        {
            double p = n1 + n2 + n3;
            return p;
        }
    }
}




