using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            // Para ello existe la siguiente escala de precios:
                            //i5 (1)	i7 (2)	i9 (3)
            
            //8 RAM (1)	     USD 800	USD 900	USD 1200
            //16 RAM (2)	 USD 900	USD 1000 USD 1400
            //32 RAM (3)	USD 1000	USD 1400 USD 2000
            
            
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, 
            //lo cual tiene un costo  adicional de USD 300. 
            //Hacer un programa que solicite la opción de procesador, 
            //la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y 
            //calcule y emita por pantalla el monto de la máquina seleccionada.

         //-----------------------------------------------------------------------

            //variables
        
            
                
            
            int ram,cpu, disco;
            float precio=0;
            //int cpu = "1,2,3";
           //int valor=0;

            Console.WriteLine("ingrese opcion de ram");
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese opcion de cpu");
            cpu = int.Parse(Console.ReadLine());
            
            Console.WriteLine("amplia disco?");
            disco = int.Parse(Console.ReadLine());

            switch (cpu){
                case 1:
                switch (ram){
                     case 1:
                     precio = 800;
                     Console.WriteLine(" i5 y 8gb ram ");
                     break;

                     case 2:
                     precio = 900;
                     Console.WriteLine("i5 y 16gb ram" );
                     break;

                     case 3:
                     precio = 1000;
                     Console.WriteLine("i5 y 32gb ram");
                     break;
                }break;
            
                case 2:
                switch (ram){
                    case 1:
                    precio = 900;
                    Console.WriteLine("i7 y 8gb ram");
                    break;

                    case 2:
                    precio = 1000;
                    Console.WriteLine("i7 y 16gb ram");

                    break;

                    case 3:
                    precio = 1200;
                    Console.WriteLine("i7 y 32gb ram");

                    break;
                }break;
                
                case 3 :
                switch (ram){
                    case 1:
                    precio = 1200;
                    Console.WriteLine("i9 y 8gb ram");

                    break;

                    case 2:
                    precio = 1400;
                    Console.WriteLine("i9 y 16gb ram");

                    break;

                    case 3:
                    precio = 2000;
                    Console.WriteLine("i9 y 32gb ram");

                    break;
                }break;
            }  
             //aca terminan las opciones de procesador y ram
        
         if(disco==1){
         
         Console.WriteLine("su precio final es "+(precio + 300));
         }else{
         Console.WriteLine("su precio final es de "+precio);
            }
            
        }
        
            

  
    }            






            
              
            



            
            
            
        
     
}
