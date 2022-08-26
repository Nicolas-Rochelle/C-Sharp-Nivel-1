using System;

namespace ejer7dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        { //9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
          //de aquellas personas mayores a 18 años.
          
           // declaro variables
         //    int  numero, edades = 0,con = 0 , resultado;
         //    for (int x = 0; x < 5; x++)
         //    {
         //     Console.WriteLine("ingrese un numero: ");
         //     numero = int.Parse(Console.ReadLine());

         //     if(numero > 18){
         //         con++;
         //         edades+=numero;
         //     }
         //    }resultado = edades/ con;
            
         //     Console.WriteLine("el promedio de edades es de "+ resultado);

         //======================================================================================================================================
     
         //8. Hacer un programa que solicite una lista de números que corta cuando se
         //ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.


            int pmenor , smenor = 0, numero;
            bool ban = false, banp = false;

            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            
            pmenor = numero;


            while (numero != 0)

            {   if(banp == false){
                pmenor = numero;
                banp = true;
                }else if(numero < pmenor)
               {
                smenor = pmenor;
                pmenor = numero;
                }else if(ban == false){
                    smenor = numero;
                    ban = true;
                }else if(numero < smenor){
                    smenor = numero;
                }
             
             Console.WriteLine("ingrese un numero");
             numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el primer menor es: " + pmenor +"y el segundo menor es : "+smenor);
                







                
            


        }
    }
}
