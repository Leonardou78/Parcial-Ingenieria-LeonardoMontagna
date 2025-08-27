using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases;

namespace Parcial_de_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionLibro gestionLibro = new GestionLibro();
            
            bool salir = false;
            while (salir == false)
            {
                MostrarMenu();

                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        //1- registrar un libro.
                        Console.WriteLine("seleccione una opcion: ");
                        Console.WriteLine("1 - Registrar un libro Fisico.");
                        Console.WriteLine("2 - Registrar un libro Digital.");

                        int tipoLibro = int.Parse(Console.ReadLine());

                        if(tipoLibro==1)
                        {
                            Console.WriteLine("Ingrese el ISBN: ");
                            int isbnLibroFisico = int.Parse(Console.ReadLine());
                            if(gestionLibro.BuscarLibro(isbnLibroFisico)==null)
                            {
                                Console.WriteLine("Ingrese el titulo del libro: ");
                                string tituloLibro = Console.ReadLine();

                                Console.WriteLine("Ingrese el autor: ");
                                string autorLibro = Console.ReadLine();

                                //Aca le agregue true porque en teoria si recien lo creas no tiene ninguna reserva.
                                Libro libroFisico = new LibroFisico(isbnLibroFisico, tituloLibro, autorLibro, true);
                                gestionLibro.AgregarLibro(libroFisico);
                            }
                            else
                            {
                                while (true)
                                {
                                    Console.WriteLine("Valor repetido ingrese otro.");
                                    isbnLibroFisico = int.Parse (Console.ReadLine());
                                    if (gestionLibro.BuscarLibro(isbnLibroFisico) == null)
                                    {
                                        Console.WriteLine("Ingrese el titulo del libro: ");
                                        string tituloLibro = Console.ReadLine();

                                        Console.WriteLine("Ingrese el autor: ");
                                        string autorLibro = Console.ReadLine();

                                        //Aca le agregue true porque en teoria si recien lo creas no tiene ninguna reserva.
                                        Libro libroFisico = new LibroFisico(isbnLibroFisico, tituloLibro, autorLibro, true);
                                        gestionLibro.AgregarLibro(libroFisico);
                                        break;
                                    }
                                    else
                                    {

                                    }

                                }
                                
                            }
                           

                        }
                        else if (tipoLibro == 2)
                        {
                            Console.WriteLine("Ingrese el ISBN: ");
                            int isbnLibroDigital = int.Parse(Console.ReadLine());
                            if (gestionLibro.BuscarLibro(isbnLibroDigital) == null)
                            {
                                Console.WriteLine("Ingrese el titulo del libro: ");
                                string tituloLibro = Console.ReadLine();

                                Console.WriteLine("Ingrese el autor: ");
                                string autorLibro = Console.ReadLine();

                                //Aca le agregue true porque en teoria si recien lo creas no tiene ninguna reserva.
                                Libro libroDigital = new LibroDigital(isbnLibroDigital, tituloLibro, autorLibro);
                                gestionLibro.AgregarLibro(libroDigital);
                            }
                            else
                            {
                                while (true)
                                {
                                    Console.WriteLine("Valor repetido ingrese otro.");
                                    isbnLibroDigital = int.Parse(Console.ReadLine());
                                    if (gestionLibro.BuscarLibro(isbnLibroDigital) == null)
                                    {
                                        Console.WriteLine("Ingrese el titulo del libro: ");
                                        string tituloLibro = Console.ReadLine();

                                        Console.WriteLine("Ingrese el autor: ");
                                        string autorLibro = Console.ReadLine();

                                        //Aca le agregue true porque en teoria si recien lo creas no tiene ninguna reserva.
                                        Libro libroDigital = new LibroDigital(isbnLibroDigital, tituloLibro, autorLibro);
                                        gestionLibro.AgregarLibro(libroDigital);
                                        break;
                                    }
                                    else
                                    {

                                    }

                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor no valido.");
                        }

                            break;
                    case 2:
                        //2- Registrar Prestamo de un libro.
                        Console.WriteLine("Ingrese el ISBN del libro: ");
                        int isbnLibro = int.Parse(Console.ReadLine());

                        Libro libro = gestionLibro.BuscarLibro(isbnLibro);

                        if (libro == null)
                        {
                            Console.WriteLine("El libro no se encontro.");

                        }
                        else
                        {
                            Console.WriteLine("Ingrese la duracion del prestamo: ");
                            int duracion = int.Parse(Console.ReadLine());

                            Prestamo nuevoPrestamo = new Prestamo(libro,duracion);
                            libro.AgregarPrestamo(nuevoPrestamo);

                        }

                            break;
                    case 3:
                        //3- Mostrar Datos.
                        Console.WriteLine("Ingresa ISBN: ");

                        int isbn = int.Parse(Console.ReadLine());

                        libro = gestionLibro.BuscarLibro(isbn);

                        if (libro == null)
                        {
                            Console.WriteLine("El libro no existe.");
                            
                        }
                        else
                        {
                            libro.MostrarDatos();
                        }
                            break;
                    case 4:
                        //4- Mostrar todos los libros y estadistica.

                        gestionLibro.MostrarLibros();

                        break;
                    case 5:
                        //5- Salir.
                        salir = true;
                        break;
                        
                }
            }
        }
        static void MostrarMenu()
        {
            Console.WriteLine("**-Menu de consola-**");
            Console.WriteLine("Opciones: ");

            Console.WriteLine("1 - Registrar Libro.");
            Console.WriteLine("2 - Registrar Prestamo de un libro.");
            Console.WriteLine("3 - Mostrar Informacion de un libro.");
            Console.WriteLine("4 - Mostrar todos los libros y estadisticas Generales.");
            Console.WriteLine("5 - Salir");
        }
    }
}
