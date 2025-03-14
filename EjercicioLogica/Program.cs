int[] nums = new int[5];
Console.WriteLine("Ingrese 5 numeros enteros: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"nums[{i}]");
    Console.Write("-> ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("--------------------------------");
int menor = nums[0];
int indice = 0;

Console.WriteLine("Los numeros ingresados son: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"nums[{i}] = {nums[i]}");
    if (nums[i] < menor)
    {
        menor = nums[i];
        indice = i;
    }
}

Console.WriteLine("--------------------------------");
Console.WriteLine($"El numero menor es -> nums[{indice}] = {menor}");

Console.ReadKey();