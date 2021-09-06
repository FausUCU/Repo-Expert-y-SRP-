using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /*public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        /*
        }
        /*
        La clase Libro y la clase AlamcenarLibro deverian ser clases distintas, segun los principios
        de SRP cada clase deve tener la informacion para cumplir con su responsavilidad y solo eso
        sugeriria separa la el almacenado de libro en su propia clase y implementarle un metodo en ella para que le introduscas un libro
        junto con su posicion
        */
    }
    //Aka crea una clase Almacenar para a la que se le incorpore como informacion sector, estante y un Librio de la clase libro
    //Como esta separada de la clase Libro se mantiene las funciones separadas
    public class Almacenar
        {
            public List<Libro> libros = new List<Libro>();
            public Almacenar()
            {
                
                           
            }

            public void AlmacenarLibro(String sector, String estante, Libro libro)
            {
                libro.SectorBiblioteca = sector;
                libro.EstanteBiblioteca = estante;
                libros.Add(libro);
                

            }

        }

    

}
