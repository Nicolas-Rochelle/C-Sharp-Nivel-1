using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar 4 números. 
            //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .


            //declaro variables pido y guardo valores.
            int a,b,c,d;
            
            Console.WriteLine("ingrese un numero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            d = int.Parse(Console.ReadLine());
         
         // poceso

          if(a > b && b > c && c > d){
            Console.WriteLine("estan ordenados de forma decreciente");       

          }else{
            Console.WriteLine("no estan ordenados");
          }

         Console.WriteLine("Fin de su programa");














        }
    }
}
