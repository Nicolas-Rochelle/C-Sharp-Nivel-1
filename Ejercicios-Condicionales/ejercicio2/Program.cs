using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
          // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.  
         // --------------------------------------------------------------------------------------------------------------------------------
         //declaro variables

         int n1;
         // 
 
          Console.WriteLine("ingrese un numero");
          n1 = int.Parse(Console.ReadLine());
         
         // 

         if(n1 > 0){
             Console.WriteLine("positivo");
         }else{
             if(n1 < 0){
                 Console.WriteLine("Negativo");
             }else{
                 Console.WriteLine("es cero");
             }

         }
         

        
         









        }
    }
}
