using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        { //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
          // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
          
            int numero, con, conGrupo = 0; 

                 
                 
            do  
            {  conGrupo++;
               Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                con=0;
                while (numero > 0)
                {
                    con++;

                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());   
                }Console.WriteLine("la cantidad de numero de la lista " +conGrupo+ "es" +con);
                
            } while (numero >= 0);





            
        }
    }
}
