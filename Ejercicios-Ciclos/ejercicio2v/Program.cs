using System;

namespace ejercicio2v
{
    class Program
    {
        static void Main(string[] args)
        { //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
          //Solo se debe emitir UN valor por pantalla
            int n,con = 0;

            for (int x = 0; x < 10; x++)
            { Console.WriteLine("ingrear numero");
              n = int.Parse(Console.ReadLine());
              if(con < n ){
              con = n;}
                
                
            } Console.WriteLine("el mayor es :" + con);








        }
    }
}
