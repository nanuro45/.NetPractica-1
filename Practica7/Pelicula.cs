using System;
using Practica;

namespace Pracitca{

    public class Pelicula:IAlquilable{
        

        public void seAlquila(Persona o){
            Console.WriteLine($"Alquilando pelicula a {o}");
        }

        public void seDevuelve(Persona p)
        {
            throw new NotImplementedException();
        }

        public void seDevuevle(Persona p)
        {
            Console.WriteLine($"Pelicula devuelta por {p}");
        }
    }
}
