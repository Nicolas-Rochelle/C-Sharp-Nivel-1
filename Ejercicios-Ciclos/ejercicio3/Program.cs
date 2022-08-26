using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {//3. Hacer un programa que solicite 20 edades y
         // luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            
            //declaro variables

            int edad, acu = 0, resultado, con = 0;

         

          //inicio el for

          for (int x = 0; x < 20; x++)
          {  Console.WriteLine("ingrese edad");
             edad = int.Parse(Console.ReadLine());
            if(edad > 18){
                acu += edad;
                con++;
            }

            
          } resultado = acu/con;
           
           Console.WriteLine("su promedio es"+resultado);

        













        }
    }
}
