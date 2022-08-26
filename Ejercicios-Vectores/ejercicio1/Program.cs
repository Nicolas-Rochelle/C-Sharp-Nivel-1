using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        { //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
          // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
          
          //declaro variables y vector numeros
          int max,pos;
          int[] vNumeros = new int[5];

         //inicio el ciclo for para guardar los numeros en el vector.

         for (int x = 0; x < 5; x++)
         {
            Console.WriteLine("ingrese un numero");
            vNumeros[x] = int.Parse(Console.ReadLine());
           
         }
         pos = 1;
         max = vNumeros[0];
         //for para recorrer el vector .
         for (int x = 0; x < 5; x++)
         {  
            if(vNumeros[x] > max){
            max = vNumeros[x];
            pos = x+1; }
            
         }
            Console.WriteLine("su numero mayor es: "+ max + "y su posicion es :"+ pos);



        }
    }
}
