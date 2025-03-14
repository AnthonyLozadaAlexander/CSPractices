float Nums = 0, promedio = 0, sum = 0;
string invalidNums = "";
int count = 0;
Console.WriteLine("-----------Bienvenido-----------");
do
{
    Console.WriteLine("Ingrese numeros positivos: ");
    Console.Write("-> ");
    invalidNums = Console.ReadLine();

    if (!float.TryParse(invalidNums, out float nums))
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("Error: Debe Ingresar Numeros Positivos");
        Console.WriteLine("-------------------------------------\n");
      
    }
    else if (nums <= 0)
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("Error: Debe Ingresar Numeros Positivos");
        Console.WriteLine("-------------------------------------\n");
        Nums = 0;
    }
    else
    {
        Nums = nums;
        Console.WriteLine("\nNumero Ingresado: " + Nums);
        sum = sum + Nums; // suma los numeros positivos ingresados para despues sacar el promedio
        count = count + 1;
        Console.WriteLine("count -> " + count + "\n");
        
    }
}while(Nums > 0 || (float.Parse(invalidNums) > 0));

promedio = (sum / count);
Console.WriteLine("\n-----------------------------------------------");
Console.WriteLine("Suma de los numeros positivos ingresados: " + sum);
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("-----------------------------------------------\n");

Console.ReadKey();