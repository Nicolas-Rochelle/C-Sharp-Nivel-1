﻿using System;

namespace ejercicio4v
{
    class Program
    {
        static void Main(string[] args)
        { //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
          // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
         int n,cont=0;
         //cont = 0;

         Console.WriteLine("ingrese un numero");
         n = int.Parse(Console.ReadLine());

         for (int x = 1; x <= n; x++){
         
         
          if(n % x == 0 ){
            cont++;
         }
          


         }
          if(cont==2){
            Console.WriteLine("es primo "); 
         }else{
            Console.WriteLine("No es primo"); 
            
        
                                                                                                                          

         }
            
         
         
         
           
           
           
            



        }
    }
}
