using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        { //5. Hacer un programa que solicite 20 números y 
          //luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
         bool bandPar=false;
         int n ,maxpar=0, minImpar=0;
         int conImp=0;
          
          for (int x = 0; x < 5; x++)
          { 
             Console.WriteLine("ingrese un numero");
             n = int.Parse(Console.ReadLine());
             if(n % 2 ==0){
                //remplazo (conPar++;) por bandera bool (VoF) concepto nuevo. 
                if(bandPar==false){
                    maxpar = n;
                    bandPar=true;
                }else if(n > maxpar){
                    maxpar=n;
                }
                   
             }else{
                conImp++;
                if(conImp==1){
                    minImpar = n;
                }else if(n < minImpar){
                    minImpar=n;
                }


             }
                   

            }
          Console.WriteLine("el maximo par es:" +maxpar);
        
          Console.WriteLine("el minimo impar es:" +minImpar);

        } 


    }      


             



             

             










            
}        






           
