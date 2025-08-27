using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Prestamo
    {
        public Libro Libro { get; set; }
        public DateTime Fecha {  get; set; }
        public int Duracion {  get; set; }

        public Prestamo(Libro libro, int duracion)
        {
            Libro = libro;
            Fecha = DateTime.Now;
            Duracion = duracion;
        }
    }
}
