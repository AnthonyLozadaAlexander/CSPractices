using System;

namespace Datos_Primitivos
{

    internal class Program
    {

        static void Main(string[] args)
        {
            // Recordar que es importante definir correctamente la variable
            // en mayusculas o minusculas porque C# puede reconocerlas 
            // diferentes si tienen una pequeña diferencia de mayus o minus

           int Edad;
           // Nombre = "Anthony";
           string Nombre;
           double Sueldo;
           bool Casado;
           // Puede ser True o False
  
           Console.Write("Cual es tu nombre: ");
           Nombre = Console.ReadLine();

           Console.Write("Ingresa tu edad: ");
           // Convert.ToInt32 nos ayuda a convertir un numero de entrada de tipo 
           // texto a tipo entero
           Edad = Convert.ToInt32(Console.ReadLine());

           Console.Write("Ingresa tu sueldo: ");
           // Convert.ToDouble nos ayuda a convertir un numero decimal de entrada
           // de tipo texto a tipo double
           Sueldo = Convert.ToDouble(Console.ReadLine());

           Console.Write("Te encuentras Casado?: ");
           // Convert.ToBoolean nos ayuda a convertir un texto de entrada a
           // tipo boolean 
           Casado = Convert.ToBoolean(Console.ReadLine());
             
            // Aqui imprimimos los datos generales mas su dato de la variable respectivamente 
           Console.WriteLine("Tu nombre es "+ Nombre + " y tu edad es " + Edad);  
           Console.WriteLine("Tu sueldo es "+ Sueldo + " y la consulta de casado es: " + Casado);  

           Console.ReadKey();
            

        }

    }

}
