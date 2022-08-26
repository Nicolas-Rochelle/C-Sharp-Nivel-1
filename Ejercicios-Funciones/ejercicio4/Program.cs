using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        { //4. Hacer una función de tipo void (porque no va a devolver nada) 
          //llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
          //Que analice el número y escriba variable recibida por referencia con:
          //a. 1 si el número es positivo.
          //b. -1 si el número es negativo.
          //c. 0 si el número es cero.
            Console.WriteLine("Hello World!");
        }
        static void posnegcero(int a , ref int n){
            if (a > 0)
            {
                n = 1;
            }else if(a == 0){
                n = 0;
            }else {
                n = -1;
            }
        }
    }
}
