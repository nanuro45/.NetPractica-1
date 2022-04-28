using System;
using Pracitca;

namespace Practica{

    class Libros : IReciclable, IAlquilable
    {
        public void reciclado()
        {
            Console.WriteLine("Reciclando Libro");
        }

        public void seAlquila(Persona p)
        {
            Console.WriteLine($"Libro alquilado por {p}");
        }

        public void seDevuelve(Persona p)
        {
            Console.WriteLine($"Se devolvio el libro alquilado por {p}");
        }
    }
}
