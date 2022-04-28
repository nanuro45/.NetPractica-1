using System;
using Pracitca;

namespace Practica{

    public class PeliculaClasica: Pelicula, IVendibles{
        public new virtual void seAlquila(Persona p) => Console.WriteLine($"Se alquilo Pelicula Clasica a {p}");

        public new virtual void seDevuevle(Persona p) => Console.WriteLine($"Pelicula Clasica devuelta por {p}");
        
        public void vendido(Persona x)
        {
            Console.WriteLine($"Se vendio Pelicula Clasica a {x}");
        }
    }
}
