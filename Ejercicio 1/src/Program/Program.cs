using System;

namespace Expert_SRP
{
    class Program
    {
        //Clase Alfajor es la clase experta en sus datos
        //Clase Kiosko no cumple SRP debido a que tiene 2 razones de cambio y no una como indica el principio
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5);
            Kiosco k = new Kiosco();
            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
