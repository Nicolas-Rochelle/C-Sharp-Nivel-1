using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        { //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
          // Hacer un programa para ingresar números. 
          //El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            //declaro variables 
            int numero,promedio,cont = 0, acu = 0 ;
            
             
            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                
                 
                 
                if(primo(numero)){
                    acu += numero;
                    cont ++;
                }

              Console.WriteLine("ingrese un numero");
              numero = int.Parse(Console.ReadLine());

            }
            
             promedio = acu / cont;

             Console.WriteLine("el promedio es: "+promedio);











        }
        static bool primo(int a){
            int cont = 0;
            for (int x = 1 ; x <= a; x++)
            {
                if(a % x == 0)
                cont ++;
            }

            if(cont == 2)
            {
                return true;
            }else{
                return false;
            }

            
        }
    }
}
