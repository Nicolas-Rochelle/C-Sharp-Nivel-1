using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        { //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
          //- Número de Artículo (1 a 15)
          //- Cantidad Vendida 
          //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
          //Se pide determinar e informar:
          //a) El número de artículo que más se vendió en total.
          //b) Los números de artículos que no registraron ventas.
          //c) Cuantas unidades se vendieron del número de artículo 10.

          //declaro variables y vector.
          int cantidadVendida,numeroArticulo,max,art;
          int[] vAcu = new int[15];
          //for para poner el vector en 0
          for (int x = 0; x < 15; x++)
          {
            vAcu[x] = 0;
          }

          Console.WriteLine("ingrese el numero de articulo");
          numeroArticulo = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese la cantidad vendida");
          cantidadVendida = int.Parse(Console.ReadLine());

          while (numeroArticulo != 0 )
          {
            vAcu[numeroArticulo -1 ] += cantidadVendida;

            Console.WriteLine("ingrese el numero de articulo");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());
          }
            

            for (int x = 0; x < 15; x++)
            {
              if(vAcu[x] == 0){
                Console.WriteLine("el numero de articulo que no registro ventas"+(x+1));
              }
            }
           
         max = vAcu[0];
         art = 1; 
            for (int x = 0; x < 15; x++)
            {
              if (vAcu[x] > max)
              {
                max = vAcu[x];
                art = x+1;
              }
            }

         Console.WriteLine("el producto mas vendido es "+art+"y la candidad maxima es" +max);

          Console.WriteLine("la cantidad vendida del art 10 es :"+ vAcu[9]);
    
        }
    }
}
