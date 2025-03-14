
using System;

namespace Datos_Primitivos
{

    internal class Program
    {

        static void Main(string[] args)
        {
           // Definicion De Variables 

           string Nombre;
           int Edad;

           // Con Const convertimos una variable a constante la cual no podra ser modificada despues
            const double Sueldo = 2500 + 100;

           Nombre = "Anthony";
           Edad = 20;
           
           // Sueldo = Sueldo + 100;
           // Aqui se esta sumando el dato de la variable Sueldo + 100 

           // Sueldo = Sueldo + 100;

           Console.WriteLine("Mi Nombre es " + Nombre + " y mi edad es " + Edad + " y tengo el sueldo de " + Sueldo);
           Console.ReadKey();

        }

    }

}