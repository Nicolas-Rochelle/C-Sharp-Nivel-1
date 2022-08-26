using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        { //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
          //Luego hacer un programa que pida el precio de un artículo 
          //y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
          int articulo,cantVendida,resultado;
            Console.WriteLine("ingrese el precio del articulo");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantVendida = int.Parse(Console.ReadLine());

            resultado = producto(articulo,cantVendida);
            Console.WriteLine("monto total a pagar: "+resultado);


        }
        static int producto(int a , int b ){
            int resultado;
            resultado = a * b;
            return resultado;
        }
        
    }   
}
