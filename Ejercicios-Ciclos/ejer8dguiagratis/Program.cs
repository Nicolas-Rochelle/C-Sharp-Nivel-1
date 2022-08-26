using System;

namespace ejer8dguiagratis
{
    class Program
    {
        static void Main(string[] args){
         //  //10. Hacer un programa que solicite 20 números y luego emitir por pantalla el
         //   //máximo de los números pares y el mínimo de los números impares.
         //   int parMayor= 0, imparMenor = 0,numero;
         //   bool banderaPar = false ,banderaImpar = false;

         //   for (int x = 0; x < 5; x++)
         //   {
         //     Console.WriteLine("ingrese un numero");
         //     numero = int.Parse(Console.ReadLine());
         //      if(numero % 2 == 0){
         //         if(banderaPar == false){
         //            parMayor=numero;
         //            banderaPar = true;
         //         }else if(numero> parMayor){
         //            parMayor=numero;
         //         }
         //     }else if(banderaImpar==false){
         //         imparMenor=numero;
         //         banderaImpar=true;
         //     }else if(numero < imparMenor){
         //         imparMenor = numero;
         //     }
         //   } Console.WriteLine("el par mayor es:" +parMayor);
         //     Console.WriteLine("el impar menor es:" +imparMenor);
        

         //======================================================================================================================
            //9. Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
            //posición en la que fue encontrado cada uno de los mínimos.

            int pmenor , smenor = 0, numero,p = 1,p1=p,p2=0;
            bool ban = false, banp = false;

            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            
            pmenor = numero;


            while (numero != 0)

            {   
                p++;
                if(banp == false){
                pmenor = numero;
                banp = true;
                p1 = p;
                }else if(numero < pmenor)
               {
                smenor = pmenor;
                pmenor = numero;
                p2=p1;
                p2=p;
                
                }else if(ban == false){
                    smenor = numero;
                    ban = true;
                    p2=p;
                    
                }else if(numero < smenor){
                    smenor = numero;
                    p2=p;

                    
                }
             
             Console.WriteLine("ingrese un numero");
             numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el primer menor es: " + pmenor +"y su pocicion es : "+p1 +"y el segundo menor es : "+smenor+ "y la posicion es: "+p2 );











        }
    }
}
