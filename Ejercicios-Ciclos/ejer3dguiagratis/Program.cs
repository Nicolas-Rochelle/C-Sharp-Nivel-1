using System;

namespace ejer3dguiagratis
{
    class Program
    {
        static void Main(string[] args){ 
           // //4. Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos.
           //      //int con=0;
          //      for (int x = 10 ; x > 0; x--)
          //      {
           //      //con++;
         //      Console.WriteLine(x);
                
         //      }
         //             //(for original.)
         //      //for (int x = 0; x < 10; x++)
         //===================================================================================================    
                //4. Hacer un programa que solicite dos números y luego muestre los números
                //entre el menor y el mayor de ellos. Acordate, usando While.
             
         int mayor, menor, numeroA , numeroB,con=0;

         Console.WriteLine("ingrese un numero: ");
         numeroA = int.Parse(Console.ReadLine());
         Console.WriteLine("ingrese otro: ");
         numeroB = int.Parse(Console.ReadLine());

         if (numeroA > numeroB)
         { mayor = numeroA;
           menor = numeroB;
         }else{
            mayor = numeroB;
            menor = numeroA;
         }while (menor < mayor)
         { menor++;
           con++;
           
         }Console.WriteLine(con);

            
         
                
             
            
        }
    }
}
