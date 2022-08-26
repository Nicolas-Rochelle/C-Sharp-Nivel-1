using System;

namespace ejer6dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        { //8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el
          //menor de ellos y la posición en la que fue encontrado.
           
           //variables 

        //    int numero, pos = 0, numeroMenor = 0;

        //    //for
        //    for (int x = 0; x < 5; x++)
        //    { Console.WriteLine("ingrese un numero: ");
        //      numero = int.Parse(Console.ReadLine());

        //        if( x == 0){
        //         numeroMenor = numero;
        //         pos = 1;
        //         }else if (numero < numeroMenor){
        //             numeroMenor = numero;
        //             pos = x+1;
        //         }


        //     }Console.WriteLine("el numero menor es: " + numeroMenor + "y su posicion es: "+pos);
        //========================================================================================================================================
           
          //7. Hacer un programa que solicite una lista de números que corta cuando se
          //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
          //en la que fue ingresado.

          int numero, maximo=0,pos = 0, posMayor = 0;
          bool banderamax = false;
          Console.WriteLine("ingrese un numero: ");
          numero = int.Parse(Console.ReadLine());
          while (numero !=0)
          {
           pos++;

           if(banderamax == false){
            maximo = numero;
            banderamax = true;
            posMayor = pos;
           }else if (numero > maximo){
            maximo = numero;
            posMayor = pos;
           }
           
           Console.WriteLine("ingrese un numero: ");  
           numero = int.Parse(Console.ReadLine());
          } Console.WriteLine("el numero maximo de la lista es: " +maximo+ " y su pocicion es: "+posMayor);
           
            



        }
    }
}
