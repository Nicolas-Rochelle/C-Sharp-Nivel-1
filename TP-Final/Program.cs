using System;

namespace TPFinal_Rochelle
{
    class Program
    {
        static void Main(string[] args)
        { //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
          //a. El mayor de los números pares.
          //b. La cantidad de números impares.
          //c. El menor de los números primos.
          //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            bool banPar = true, banPrimo = true;
            int cantImpar = 0, numero, mayorPar = 0, menorPrimo = 0;
            

            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());


            while (numero != 0)
            { if(par(numero)){
               if(banPar){
                mayorPar = numero;
                banPar = false;
               }else if(numero > mayorPar){
                mayorPar = numero;
               }
             }else{
                cantImpar++;
             }

               if(primo(numero)){
                 if(banPrimo){
                    menorPrimo = numero;
                    banPrimo = false;
                 }else if(numero < menorPrimo){
                    menorPrimo = numero;
                 }
               } 


              Console.WriteLine("ingrese un numero");
              numero = int.Parse(Console.ReadLine()); 
            }

          Console.WriteLine("la cantidad de numeros impares es: "+cantImpar+ " El mayor de los pares es: "+mayorPar+ " El menor de los numeros primos es: "+menorPrimo);
          
          
        }
        static bool par(int a){
            if(a % 2 == 0){
                return true;
            }else{
                return false;
            }
        }

        static bool primo(int a){
            int cont = 0;
            for (int x = 1; x <= a; x++)
            { 
                if(a % x == 0)
                    cont++;
                
            }

            if(cont == 2){
                return true;
            }else{
                return false;
            }    

        }
    }
}
