﻿using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

                    //Si vende menos de 100 litros, no hay descuento.
                    //Si vende entre 101 y 300 litros, el descuento es del 10%.
                    //Si vende entre 301 y 500 litros, el descuento es del 15%.
                    //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
                    //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule 
                    //y emita el importe con el descuento  aplicado..
         //---------------------------------------------------------------------------------------------------------------------------

            // declaro variables
         int importeTotal, litros;
            //pido datos en pantalla
         
         Console.WriteLine("ingrese su importe");
         importeTotal = int.Parse(Console.ReadLine());

         Console.WriteLine("ingrese litros");
         litros = int.Parse(Console.ReadLine());

         //proceso con if
         if(litros < 100){
            Console.WriteLine("no hay descuento");
         }else if(litros > 100 && litros <= 300){
            
            Console.WriteLine("10 % de descuento, su importe es"+importeTotal*0.90);
         }else if(litros > 300 && litros <= 500 ){
            Console.WriteLine("15 % de descuento, su importe es"+importeTotal*0.85);

         }else if (litros > 500 ){
            Console.WriteLine("25 % de descuento, su importe es"+importeTotal*0.75);
         }




                                                                                                                                                                                                                                                                                                                                                                                                      




        }
    }
}
