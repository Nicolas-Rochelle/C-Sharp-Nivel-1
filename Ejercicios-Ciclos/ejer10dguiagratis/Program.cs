using System;

namespace ejer10dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        { //11. Hacer un programa para ingresar una lista de números que corta cuando se
          //ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
          //números pares, la cantidad de positivos y la cantidad de negativos.

          int numero,conPositivos = 0 ,conNegativos = 0 ,conPimos = 0 ,conPares = 0 ,con ,jota;
          
            Console.WriteLine("ingrese un numero :");
            numero = int.Parse(Console.ReadLine());

          while (numero!=0)
          {
            if(numero > 0){
                conPositivos++;
            }else{
                conNegativos++;
            }
            if (numero % 2 ==0)
            {
                conPares++;
            }
            con = 0;
            jota=1;
            while (jota<=numero)
            {
                if (numero % jota==2)
                {
                    con++;
                }
                jota++;
            }
            if (con==2)
            {conPimos++;
                
            }
            
            Console.WriteLine("ingrese un numero :");
            numero = int.Parse(Console.ReadLine());
                
          }
          Console.WriteLine("la cantidad de numeros primos es "+conPimos+" la cantidad de numeros pares es " +conPares+ "la cantidad de positivos es" +conPositivos+"y negativos es "+conNegativos);






        }
    }
}
