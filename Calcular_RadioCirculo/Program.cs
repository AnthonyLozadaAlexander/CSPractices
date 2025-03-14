/* Forma De Calcular sin bibliotecas.

double Radio;
double Area;
const double Pi = 3.14159265;

Console.Write("Introduzca en cm, el tamaño del radio del circulo:");
Radio = Convert.ToDouble(Console.ReadLine());

Area = Pi * Radio * Radio;

Console.WriteLine("El area del circulo es: " + Area);

Console.ReadKey();

*/

//* Con Bibliotecas

using System;

class Program

{   
   static void Main()
   {

      double Radio;
      double Area;

      Console.Write("Introduzca en cm el tamaño del radio del circulo:");
      Radio = Convert.ToDouble(Console.ReadLine());

      Area = Math.PI * Math.Pow(Radio, 2);

      Console.WriteLine("El area del circulo es: " + Area);

      Console.ReadKey();


   }

}

