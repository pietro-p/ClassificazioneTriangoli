using System;

namespace metodi
{
    public class Metodo

    {
        public static double InserisciLato()
        {


            Console.WriteLine("Inserisci un Lato");
            double n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Lato Inserito non Corretto");
                Console.WriteLine("Inserire un Lato Valido");
                double n1 = double.Parse(Console.ReadLine());
                return n1;
            }
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




