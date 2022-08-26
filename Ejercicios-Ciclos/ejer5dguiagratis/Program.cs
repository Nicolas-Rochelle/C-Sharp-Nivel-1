using System;

namespace ejer5dguiagratis
{
    class Program
    {
        static void Main(string[] args)
        {   //7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el
            //máximo de ellos y la posición en la que fue ingresado.

            
            // int numero, numeroMaximo = 0 , pos = 0;

            // for (int x = 0; x < 5; x++){
            // Console.WriteLine("ingrese un numero: ");
            // numero = int.Parse(Console.ReadLine());

            //  if (numero > numeroMaximo)
            // {
            //     pos = x+1;
            //     numeroMaximo = numero;
            // }
                
            // }Console.WriteLine("el numero maximo es: " + numeroMaximo + "y su posicion es: "+pos);
         //==============================================================================================================================
         //6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
         //aclaratorio si el mismo es primo o no es primo.
         //Nota: usando While. Ya lo hicimos con FOR, ahora con While.

         int numero, con=0,acu=1;
         Console.WriteLine("ingrese un numero: ");
         numero = int.Parse(Console.ReadLine());

         while ( acu<=numero){
         if(numero % acu == 0){
            con++;
         }
            acu++;
            
         }if(con == 2){
            Console.WriteLine("es primo");
         }else{
            Console.WriteLine("no es primo");
         }
            



        }
    }
}
