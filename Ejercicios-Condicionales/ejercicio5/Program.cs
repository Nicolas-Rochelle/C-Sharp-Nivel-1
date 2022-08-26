using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y 
            //luego mostrar por pantalla cuáles son mayores a 100.
         //------------------------------------------------------------------------------------------
         //pido variables
            int n1,n2,n3,n4;

         //pido los numeros en pantalla 

         Console.WriteLine("ingrese numero uno");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero dos");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero tres");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero cuatro");
            n4 = int.Parse(Console.ReadLine());

         //proceso

         if(n1>100){
             Console.WriteLine("el numero: " + n1 + " es mayor a 100");
         }
         if(n2>100){
             Console.WriteLine("el numero: " + n2 + " es mayor a 100");
          }  
        if(n3>100){
            Console.WriteLine("el numero: " + n3 + " es mayor a 100");
        }  
        if(n4>100){
            Console.WriteLine("el numero: " + n4 + " es mayor a 100");
        }
         




        }
    }
}
