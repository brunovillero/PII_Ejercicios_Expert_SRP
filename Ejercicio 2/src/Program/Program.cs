using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //La clase libro cumple con expert
            //Debido a que contiene la informacion relacionada a los libros
            //No cumple SRP debido a que no tiene sentido que el libro pueda almacenarse
            //Quizas cambie la forma en que se almacena el libro y 
            //en ese caso es mejor mover esa responsabilidad a una clase experta en saber almacenar libros
            //Ejemplo una clase que se llame Seccion que contenga sector y estante de la biblioteca y un metodo para almacenarlo
            
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.AlmacenarLibro("A","7");
            libro2.AlmacenarLibro("B","3");

        }
    }
}
