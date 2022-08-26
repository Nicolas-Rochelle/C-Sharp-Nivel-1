using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        { //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
         // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
          //Mostrar el resultado en pantalla. Ejemplo:
          //CADENA FUENTE: “La mar estaba serena"
          //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
          //CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadena = new char[30];
            char letras;
            char letraActual;
            char letraNueva;
            int indice = 0;
            Console.WriteLine("ingrese cadena plis corta con 0.");
            letras = char.Parse(Console.ReadLine());
            while (letras != '0'&& indice < 30)
            {
                cadena[indice] = letras;
                Console.WriteLine("ingrese otra letra");
                letras = char.Parse(Console.ReadLine());
                indice++;
            }
            cadena[indice] = '\0'; //finaliza cadena con barra cero
            Console.WriteLine("la frase completa es: ");
            indice = 0;
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
        
            }
            Console.WriteLine("ingrese ingrese letra actual");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese letra nueva");
            letraNueva = char.Parse(Console.ReadLine());

            indice=0;
            while (cadena[indice]!= '\0')
            {
                if (cadena[indice] == letraActual)
                {
                    cadena[indice] = letraNueva;
                    
                }indice++;
            } 
            Console.WriteLine("la frase nueva es: ");
            indice = 0;
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
                indice++;
            }
                


        }
    }
}
