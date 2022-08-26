using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        { //1. Hacer un programa para ingresar 10 números. 
          //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

          //declaro variables
          int n, cantPrimo = 0, con, primo = 0;

            

        for (int y = 0; y < 5; y++)
        {
          Console.WriteLine("ingrese un numero");
          n = int.Parse(Console.ReadLine());
          con=0;
          for (int x=1; x <= n; x++)
          {  if(n % x == 0){
            con++;
          }
            
          }
          if(con == 2){
            primo++;
            
          cantPrimo = primo;
          }  
        }    

          
         Console.WriteLine("la cantidad de primos es: "+cantPrimo);
          
            
            





        }
    }
}
