using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class LibroFisico : Libro
    {
        public bool Disponible {  get; set; }

        public LibroFisico(int isbn, string titulo, string autor, bool disponible):base(isbn, titulo, autor)
        {
            this.Disponible = disponible;
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($"ISBN: {ISBN}.");
            Console.WriteLine($"Titulo: {Titulo}.");
            Console.WriteLine($"Autor: {Autor}.");
            Console.WriteLine($"Cantidad de prestamos: {prestamos.Count}.");
            Console.WriteLine($"Disponibilidad: ");
            if (Disponible = true)
            {
                Console.WriteLine("Esta Disponible.");
            }
            else
            {
                Console.WriteLine("No Disponible.");
            }
            
        }
        public override int TipoLibro()
        {
            return 1;
        }
    }
}
