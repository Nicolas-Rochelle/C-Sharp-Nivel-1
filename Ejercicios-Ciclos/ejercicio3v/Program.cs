using System;

namespace ejercicio3v
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades 
            //y luego calcule el promedio de edad de aquellas personas mayores a 18 años.


            int resultado, con = 0, acu = 0, edad;

            for (int x = 0; x < 5; x++)
            { Console.WriteLine("ingrese edad: ");
              edad = int.Parse(Console.ReadLine());

              if(edad > 18){
                acu+=edad;
                con++;

              }

            } resultado = acu/con;
            Console.WriteLine("el promedio es: " +resultado);

              
                















        }
    }
}
