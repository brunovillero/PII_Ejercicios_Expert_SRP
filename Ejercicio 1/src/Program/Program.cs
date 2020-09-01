using System;

namespace Expert_SRP
{
    class Program
    {
        //Clase Alfajor es la clase experta en sus datos
        //Clase Kiosko no cumple SRP debido a que tiene 2 razones de cambio 
        //Puede comprar y Convertir a Pesos y no una como indica el principio
        //Lo correcto para cumplir con srp es crear una clase que se encargue unicamente para saber si puede comprar 
        //y otra para convertir a pesos
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
