using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class LibroDigital : Libro
    {

        public LibroDigital(int isbn, string titulo, string autor):base(isbn, titulo,autor)
        {

        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"ISBN: {ISBN}.");
            Console.WriteLine($"Titulo: {Titulo}.");
            Console.WriteLine($"Autor: {Autor}.");
            Console.WriteLine($"Cantidad de prestamos: {prestamos.Count}");
           
        }
        public override int TipoLibro()
        {
            return 2;
        }

    }
}
