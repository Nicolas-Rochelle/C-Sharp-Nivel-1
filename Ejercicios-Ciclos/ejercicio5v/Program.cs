using System;

namespace ejercicio5v
{
    class Program
    {
        static void Main(string[] args)
        { //5. Hacer un programa que solicite 20 números y 
          //luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
         
          //declaro variables

          int menorImpar = 0 ,mayorPar = 0, numero;
          bool banderaPar = false , banderaImpar = false;
          
          //arranco el ciclo for pidiendo datos 

          for (int x = 0; x < 5; x++)
          { Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0){
                if(banderaPar == false){
                    mayorPar = numero;
                    banderaPar = true;
                }else if(numero > mayorPar){
                    mayorPar = numero;
                }
            }else if(banderaImpar == false){
                menorImpar = numero;
                banderaImpar = true;
            }else{
                if(numero < menorImpar){
                    menorImpar = numero;
                }
            }
            
          }
          Console.WriteLine("el par mayor es: " + mayorPar);

          Console.WriteLine("el menor impar es: "+ menorImpar);




          



            
        }
    }
}
