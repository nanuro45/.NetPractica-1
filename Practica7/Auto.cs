//Autos de interface//

using System;

namespace Practica{

    class Auto: ILavables, IVendibles, IReciclable, IComercial, IImportante{
        public Auto(){
        }
        
        public void vendido(Persona p){
            Console.WriteLine($"vendiendo auto a {p}");
        }
        public void lavado()
        {
            Console.WriteLine("Lavando auto.");
        }
        public void secado(){
            Console.WriteLine("Secando auto.");
        }
        public void reciclado(){
            Console.WriteLine("Reciclando auto");
        }
        void IImportante.Importa() =>Console.WriteLine("Auto importante");
        void IComercial.Importa() => Console.WriteLine("Auto se vende al exterior");

        public void Importa() => Console.WriteLine("Metodo Importar() de la clase auto");
    }
    


}
