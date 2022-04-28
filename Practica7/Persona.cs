using System;

namespace Practica{
    public class Persona: IComercial, IImportante, INombrable{
    
        string Nombre{get;set;}
        string INombrable.Nombre{get;set;}
        public Persona(){}

        public int ComparteTo(object obj){
            string s= this.Nombre;
            string s2 = (obj as INombrable).Nombre;
            return s.CompareTo(s2);
        }

        public override string ToString(){
            return this.Nombre+ " es una persona";
        }

        void IComercial.Importa() => Console.WriteLine("Persona Importante");
        void IImportante.Importa() => Console.WriteLine("Persona vendiendo al exterior");

        public void Importa() => Console.WriteLine("Metodo Importar() del metodo Persona");
    }
}
