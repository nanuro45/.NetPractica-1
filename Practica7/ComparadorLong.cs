using System;

namespace Practica{

    interface IEnumerable{
        int rango(int i, int x, int j);

        int potencia(int b, int k);
        int DivisiblePor(IEnumerable e, int i);
    }
    public class ComparadorLongitud: IComparer{
        public string nombre{get;set;}

        public System.Collections.Generic.IEnumerable<int> rango(int i, int j, int p){
            int aux = i;
            while(aux <= j){
                yield return aux;
                aux+= p;
            }
        }
        System.Collections.Generic.IEnumerable<int> potencia(int i, int j){
            int aux = 0;
            while(aux <= j){
                int p = 1;
                for(int g=0; g < aux; g++){
                    p *= i;
                }
                yield return aux;
                aux++;
            }
        }
        //System.Collections.Generic.IEnumerable<int> DivisiblePor(IEnumerable x, int y){
          //  foreach(int i in x){
              //  if(i % y == 0){
            //        yield return i;
               // }
           // }
        //}
        public int CompareTo(object o, object y){
            INombrable s = o as INombrable;
            INombrable x = y as INombrable;
            return s.Nombre.Length.CompareTo(x.Nombre.Length);
        }

        public int Compare (object x, object y){
            return new Random().Next(-2,2);
        }
    }
}
