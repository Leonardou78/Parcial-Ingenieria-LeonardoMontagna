using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class GestionLibro
    {
        public List<Libro>libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public Libro BuscarLibro(int isbn)
        {
            Libro libro = null;
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].ISBN == isbn)
                {
                    libro = libros[i];
                    break;
                }
                else
                {

                }
            }
            return libro;
        }

        public void MostrarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay registro de ningun libro");
            }
            else
            {
                int totalPrestamo = 0;
                int librosFisicos= 0;
                int librosDigitales = 0;
                for(int i = 0;i < libros.Count; i++)
                {
                    libros[i].MostrarDatos();
                    totalPrestamo = totalPrestamo + libros[i].prestamos.Count;
                    if (libros[i].TipoLibro()==1)
                    {
                        librosFisicos++;
                    }
                    else if (libros[i].TipoLibro()==2)
                    {
                        librosDigitales++;
                    }
                }


                Console.WriteLine();
                Console.WriteLine($"Cantidad de prestamos: {totalPrestamo}.");
                Console.WriteLine($"Cantidad Libros Digital: {librosDigitales}.");
                Console.WriteLine($"Cantidad Libros Fisico: {librosFisicos}.");
            }
        }

    }
}
