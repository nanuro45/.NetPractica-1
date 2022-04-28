using System;

namespace Practica{
    public class Autos{
        public string Marca{get{
            return this.Marca;           
        }
        set{
            this.Marca = Marca;
           }
        }
        public string Modelo{get{
            return this.Modelo;
        }   
        set{
            this.Modelo = Modelo;
            }
        }

        public Autos(string Marc,string mod){
            this.Marca = Marc;
            this.Modelo = mod;
        }

        public Autos()
        {
        }
    }
}
