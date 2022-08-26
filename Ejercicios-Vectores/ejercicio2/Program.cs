using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        { //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
          // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            //declaro las variables

            int[] vNum = new int [10];
            int promedio = 0, acu= 0;
            // ciclo for para guardar datos en el vector

            for (int x = 0; x < 10; x++)
            {
              Console.WriteLine("ingrese un numero");
              vNum[x] = int.Parse(Console.ReadLine());
            }
              
            for (int x = 0; x < 10; x++)
            {
                acu += vNum[x];
            }
              promedio = acu/10;   
              int mayorApromedio;
            
            for (int x = 0; x < 10; x++)
            {
                if(vNum[x] > promedio){
                    mayorApromedio = vNum[x];
                    Console.WriteLine("los valores mayores son: "+mayorApromedio);
                }

            }








        }
    }
}
