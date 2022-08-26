using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        { //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
          // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
          
          int numero;
          int resultado;
          int cont = 0;
          for (int x = 0; x < 5; x++)
          {
            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            resultado = par(numero);

            if (resultado == 1 )
            {
                cont++;
            }

            
          } Console.WriteLine("la cantidad de primos es: "+cont);





        }
        static int par(int a){
            
            if (a % 2 == 0)
            {
              return 1; 
              
            }else{
                return 0;
            }

        }
    }
}
