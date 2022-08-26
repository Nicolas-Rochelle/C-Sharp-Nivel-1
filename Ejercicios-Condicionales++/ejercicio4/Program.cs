using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           //4. Hacer un programa para ingresar tres números y
           // emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.


           // declaro variables

            int a,b,c;

         // pido numeros en pantalla

           Console.WriteLine("ingrese un numero");
           a = int.Parse(Console.ReadLine());

           Console.WriteLine("ingrese otro numero");
           b = int.Parse(Console.ReadLine());

           Console.WriteLine("ingrese otro numero");
           c = int.Parse(Console.ReadLine());
            
         // proceso

         if((a+b) > b*c){
            Console.WriteLine("es mayor");
            
         }

            Console.WriteLine("Fin del programa");










        }
    }
}
