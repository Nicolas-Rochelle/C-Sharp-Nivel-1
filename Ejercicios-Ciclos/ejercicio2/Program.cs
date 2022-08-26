using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        { //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
         // Solo se debe emitir UN valor por pantalla.

         //declaro variables

         int n = 0, mayor = 0;

         //for
          for (int x = 0; x < 5; x++)
          { Console.WriteLine("ingrese un nro:");
            n = int.Parse(Console.ReadLine());
            if(x==0){
              mayor=n;
            }else{

            if (n > mayor)
             mayor = n; 
                
            


           }


            


            
          } Console.WriteLine("el mayor es: " + mayor);
        

          


            










            
        }
    }
}
