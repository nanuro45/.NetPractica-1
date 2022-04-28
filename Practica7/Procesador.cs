using System;

namespace Practica
{
    interface IComercial{
        void Importa();
    }
    interface INombrable{
        string Nombre{get;set;}
    }
    interface IComparer{}
    interface IImportante{
        void Importa();
    }
    interface IAlquilable{
        void seAlquila(Persona p);
        void seDevuelve(Persona p);
    }
    interface IAtendibles{
        void seAtendio();
    }
    interface ILavables{
        void lavado();
        void secado();
    }
    interface IReciclable{
        void reciclado();
    }
    interface IVendibles{
        void vendido(Persona x);

    }
    
    static class Procesador{
        public static void Alquilar(IAlquilable x, Persona p) =>  x.seAlquila(p);
        public static void Atender(IAtendibles x) => x.seAtendio();
        public static void Devolver(IAlquilable x, Persona p) => x.seDevuelve(p);
        public static void Lavar(ILavables x)=> x.lavado();
        public static void Secar(ILavables x) => x.secado();

        public static void Vender(IVendibles x, Persona p) => x.vendido(p);
        
    }
}
