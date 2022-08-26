using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:
         //*El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
         //*Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

         int numero,contador  , contadorImpares , grupoMayor =0 ,numMin,contadorOrdenados = 0;
         bool bandOrd;
         double porcentaje, porcentajeMayor = -1;
         for (int x = 0; x < 3; x++)
         {
            bandOrd = true;
            Console.WriteLine("ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            numMin = numero;
            contador = 0;
            contadorImpares = 0;

            while (numero !=0)
            { contador++;
              if(numero % 2 !=0){
                 contadorImpares++;
                 }
                 //punto b
                if(numero <= numMin){
                  numMin = numero;
                 }else{
                   bandOrd = false;
                 } 
                numero = int.Parse(Console.ReadLine());   
            }
             //
            porcentaje = contadorImpares * 100/contador; 
            if(porcentaje > porcentajeMayor){
                porcentajeMayor = porcentaje;
                grupoMayor = x + 1;
                }

            //punto b
            if(bandOrd){
                contadorOrdenados++;
            }


            
         }//
          Console.WriteLine(" El número de grupo con mayor porcentaje de números impares es: "+grupoMayor);
          Console.WriteLine("la cantidad de grupos ordenados de mayor a menor es"+contadorOrdenados);  


        }
    }
}
 