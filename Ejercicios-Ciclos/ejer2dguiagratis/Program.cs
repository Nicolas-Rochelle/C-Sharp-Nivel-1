using System;

namespace ejer2dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        { //Hacer un programa que solicite 20 números y calcule y emita por pantalla
          //cuántos son positivos (mayores a cero). 
          //Se debe mostrar un solo valor: elconteo final.

          //declaro variables e inicializo
         //    int numero, con = 0;
         //     for (int x = 0; x < 5; x++)
         //     {
         //     Console.WriteLine("ingrese un numero por favor: ");
         //     numero = int.Parse(Console.ReadLine());
         //     if(numero > 0)
         //     con++;
         //     } Console.WriteLine(" la cantidad de positivos son :"+con);   
         //===============================================================================================================================

         //3. Hacer un programa que solicite la edad de un grupo de personas. El programa
         //deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
         //mostrar por pantalla cuántas personas mayores se registraron.

            //variables
            int edad = 0 , con = 0;

            
             Console.WriteLine("ingrese edad :");
             edad = int.Parse(Console.ReadLine());

            while (edad >= 18)   
            { Console.WriteLine("ingrese edad :");
              edad = int.Parse(Console.ReadLine());
              
             
             con++;

            }Console.WriteLine("la cantidad de personas mayores es de  :" +con);
            




            
            
            
                
        }
    }
}
