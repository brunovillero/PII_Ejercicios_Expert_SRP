using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //La clase libro no cumple con expert
            //Debido a que contiene informacion relacionada a los libros 
            //pero tambien contiene informacion relacionada a una seccion en una biblioteca
            //lo correcto es que contenga solo informacion relacionada a un libro


            //No cumple SRP debido a que no tiene sentido que el libro pueda almacenarse
            //Quizas cambie la forma en que se almacena el libro y 
            //en ese caso es mejor mover esa responsabilidad a una clase experta en saber almacenar libros
            //Ejemplo una clase que se llame Seccion que contenga sector y estante de la biblioteca y un metodo para almacenarlo
            
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            
            Seccion seccionLibro1 = new Seccion(libro1, "A", "7"); // libro1.AlmacenarLibro("A","7");
            Seccion seccionLibro2 = new Seccion(libro1, "B", "3"); // libro2.AlmacenarLibro("B","3");
        }
    }
}
