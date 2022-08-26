using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

                     //La resta si el primero es mayor que el segundo.
                     //La suma si son iguales.
                     //El producto si el primero es menor.
                     //Se deberá emitir un cartel por pantalla con el resultado correspondiente


            // declaro variables
         int a,b,resultado;

         //pido los dos dos numero en pantalla y los guardo en las variables

         Console.WriteLine("ingrese un numero ");
         a = int.Parse(Console.ReadLine());

         Console.WriteLine("ingrese otro");
         b = int.Parse(Console.ReadLine());

         // 

         if(a > b ){
            resultado= a-b;
            Console.WriteLine("su resultado se resto y es " + resultado);
         }else if(a == b){
            resultado= a+b;
            Console.WriteLine("su resultado se sumo y es " + resultado);
         }else{
            resultado= a*b;
            Console.WriteLine("su resultado se multiplico y es " + resultado);
         }

            //muestro resultado en pantalla

            
         
           


        
         













        }
    }
}
