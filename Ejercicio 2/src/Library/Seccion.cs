using System;

namespace SRP
{
    public class Seccion
    {
        public Libro Libro { get ; set;}
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Seccion(Libro libro, String sector, String estante)
        {
            this.Libro = libro;
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.Libro = libro;
        }

    }
}
