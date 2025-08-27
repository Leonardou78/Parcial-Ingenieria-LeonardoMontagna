using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Libro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public List<Prestamo> prestamos { get; set; } = new List<Prestamo>();


        public Libro(int isbn, string titulo, string autor)
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.Autor = autor;
        }
        public virtual int TipoLibro()
        {
            return 1;
        }

        public virtual void MostrarDatos()
        {

        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            prestamos.Add(prestamo);
        }

 
    }
}
