int nums = 0, i = 0;
int [] numeros = new int[10];
string invalidNums = "";

while (i < numeros.Length) // desde 0 hasta 9
{
    Console.WriteLine("\nIndice["+i+"]");
    Console.WriteLine("Ingrese un numero del 1 al 100");
    Console.Write("-> ");
    
    if(!int.TryParse(Console.ReadLine(), out nums))
    {
        Console.WriteLine("\nIndice["+i+"]");
        Console.WriteLine("Error: El valor ingresado no es un numero\n");
        continue;
    }
    
    else if (nums > 0 && nums <= 100)
    {
        Console.WriteLine("\nIndice["+i+"]");
        Console.WriteLine("Se Ingreso Correctamente el numero: " + nums);
        numeros[i] = nums;
        i++; // incrementador del bucle while
    }
    else
    {
        Console.WriteLine("\nIndice["+i+"]");
        Console.WriteLine("Error: El numero ingresado sale del limite del rango (1 - 100)\n");
        if (i > 0 && i < numeros.Length)
        {
            i--; // decrementador del bucle while
        }
    }
}


