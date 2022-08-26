using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y 
            //luego mostrar por pantalla el menor de ellos.
         //---------------------------------------------------------------------------------------------------
            //variables

            int n1,n2,n3,n4;

            //pido los numeros 

            Console.WriteLine("ingrese numero uno");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero dos");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero tres");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese numero cuatro");
            n4 = int.Parse(Console.ReadLine());

           //pregunto con if cual es el menor de ellos

           if(n1<n2){
               Console.WriteLine("el numero" +n1+" es el menor");
           }else{
               if(n2<n3){
                   Console.WriteLine("el numero"+n2+"es el menor");
               }else{
                   if(n3<n4){
                       Console.WriteLine("el numero"+n3+"es el menor");
                   }else{
                       Console.WriteLine("el numero"+n4+"es el menor");
                   }
               }
                



           }
           
            


         















        }
    }
}
