using  System;
using Practica;

namespace Pracitca{
    class Perros : IVendibles, IAtendibles, ILavables
    {
        string nombre{get;set;}

        public Perros(){

        }
        public int CompareTo(object obj){ // sin orden en especial
            string s = this.nombre;
            string s2 = (obj as INombrable).Nombre;
            return s.CompareTo(s2);
        }

        public int CompareT(object ok){
            if(ok is Persona){
                return 0; //haciendo referencia a que entro una persona
            }
            else{
                string s = this.nombre;
                string s2 = (ok as INombrable).Nombre;
                return s.CompareTo(s2);
            }
        }
        public override string ToString()
        {
            return this.nombre + " es un perro";
        }
        public void lavado() => Console.WriteLine("Lavando perro");

        public void seAtendio() => Console.WriteLine("Perro atendido");

        public void secado() => Console.WriteLine("Sencando Perro");

        public void vendido(Persona x) => Console.WriteLine($"Se vendio perro a {x}");
    }
}
