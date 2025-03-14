int b = 60; // presupuesto
int K = 0; // guarda el valor del teclado
int D = 0; // guarda el valor del disco
int IK = 0; // Indice del teclado
int ID = 0; // Indice del disco
int[] keyboards = { 40, 50, 60 };
int[] drives = { 5, 8, 12 };
List<int> costos = new List<int>();
int suma = 0;

Console.WriteLine("--------------DATA------------");
Console.WriteLine("------------------------------");
Console.WriteLine("B = " + b);
for (int i = 0; i < keyboards.Length; i++)
{
    Console.WriteLine($"Keyboards[{i}] = {keyboards[i]}");
}

for (int j = 0; j < drives.Length; j++)
{
    Console.WriteLine($"drives[{j}] = {drives[j]}");
}


for (int i = 0; i < keyboards.Length; i++)
{
    for (int j = 0; j < drives.Length; j++)
    {
        suma = keyboards[i] + drives[j];
        if (suma < b)
        {
            costos.Add(suma);
            K = keyboards[i];
            D = drives[j];
            IK = i;
            ID = j;
        }
    }
}

Console.WriteLine("--------------RESULT------------");
if (costos.Count > 0)
{
    costos.Sort();
    Console.WriteLine($"Keyboards[{IK}] = {K}");
    Console.WriteLine($"drives[{ID}] = {D}");
    Console.WriteLine(
        $"\n {K} + {D} = {costos[costos.Count - 1]}"); // se imprime el valor mayor de la lista el cual es la suma de los dos elementos
}
else
{
    Console.WriteLine("No se puede comprar nada, -1");
}

Console.WriteLine("------------------------------");
Console.ReadKey();