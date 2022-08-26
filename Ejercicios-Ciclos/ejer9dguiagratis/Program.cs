using System;

namespace ejer9dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        { //11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
          //de los primos de la lista. En caso de no haber ningún número primo, deberá
          //aclararlo con un cartel.

          

          //variables 

         //  int numero ,con,maximoPrimo = 0;
         //  bool banPrimo = false;

         //  for (int x = 0; x < 10; x++)
         //  { Console.WriteLine("ingrese un numero: ");
         //    numero = int.Parse(Console.ReadLine());
         //    con=0;
         //    for (int y = 1; y < numero; y++)
         //    {  if(numero % y == 0){
         //     con++;
         //    }
            
         //    }if(con == 2){
         //     if(banPrimo==false){
         //       maximoPrimo = numero;
         //       banPrimo = true;
         //     }else if (numero>maximoPrimo){
         //       maximoPrimo=numero;
         //     }
         //    }else{
         //     Console.WriteLine("no hay ningun primo");
         //    }
         //  }Console.WriteLine("el numero primo mayor es: "+maximoPrimo);
         //
         //----------------------------=========================================================-----------------------------------------------------

         //10. Hacer un programa que solicite una lista de números que corta cuando se
         //ingresa un cero y luego emitir por pantalla el máximo de los números
         //negativos y el mínimo de los números positivos.


         int numero,maxPosi= 0,maxNega=0;
         bool bandneg = false , bandpos = false;

         Console.WriteLine("ingrese un numero :");
         numero = int.Parse(Console.ReadLine());

         while (numero !=0)
         { if(numero > 0 ){
            if(bandpos==false){
                maxPosi = numero;
                bandpos = true;
            }else if(numero < maxPosi){
                maxPosi = numero;
            }
         }else if(bandneg ==false){
            maxNega = numero;
            bandneg = true;
         }else if(numero > maxNega){
            maxNega = numero;
         }
          Console.WriteLine("ingrese un numero :");
          numero = int.Parse(Console.ReadLine());




         }Console.WriteLine("el maximo de los negativos es:" +maxNega+"y el minimo de los positivos es: "+maxPosi);













            


           
          





     


          
        }
    }
}
