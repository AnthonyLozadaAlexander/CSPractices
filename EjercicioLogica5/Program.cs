int [] array1 = new int[10];
int [] array2 = new int[10];
int [] array3 = new int[20];
string respuesta = "";
bool On = false;
do
{
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("           BIENVENIDO");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Ingrese los elementos del array1");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine("Array1[" + i + "]");
        Console.Write("-> ");
        array1[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nIngrese los elementos del array2");
    for (int j = 0; j < array2.Length; j++)
    {
        Console.WriteLine("Array2[" + j + "]");
        Console.Write("-> ");
        array2[j] = int.Parse(Console.ReadLine());
    }

    byte indice1 = 0;
    Console.WriteLine("\nDatos Del Arreglo1");
    foreach (int i in array1)
    {
        Console.WriteLine("Array1[" + indice1 + "] = " + i);
        indice1++;
    }

    byte indice2 = 0;
    Console.WriteLine("\nDatos Del Arreglo2");
    foreach (int j in array2)
    {
        Console.WriteLine("Array2[" + indice2 + "] = " + j);
        indice2++;
    }

    int index1 = 0;
    int index2 = 0;
    for (int k = 0; k < array3.Length; k++)
    {
        // array1 se guardara en los indices impares
        if (k % 2 == 0)
        {
            if (index1 < array2.Length)
            {
                array3[k] = array1[index1++];
            }
        }
        else // array2 se guardara en los indices pares
        {
            if (index2 < array1.Length)
            {
                array3[k] = array2[index2++];
            }
        }
    }

    byte indice3 = 0;
    Console.WriteLine("\nDatos Del Arreglo3");
    foreach (int k in array3)
    {
        Console.WriteLine("Array3["+indice3+"] = " + k);
        indice3++;
    }

    bool Error = true;
    do
    {
        Console.WriteLine("------------------");
        Console.WriteLine("\nDesea Continuar?");
        Console.WriteLine("Si = Continuar");
        Console.WriteLine("No = Salir");
        Console.WriteLine("------------------");
        Console.Write("-> ");
        respuesta = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(respuesta))
        {
            Console.WriteLine("\nError: No Puede Estar Vacio La Respuesta");
            Error = true;
        }
        else if (respuesta.Equals("Si", StringComparison.OrdinalIgnoreCase))
        {
            Error = false;
        }
        else if (respuesta.Equals("No", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nIngrese Una Tecla Para Salir..");
            if (Console.ReadKey(true).Key != ConsoleKey.NoName)
            {
                Error = false;
                On = true;
            }
        }
        else
        {
            Console.WriteLine("\nError: Respuesta Invalida");
            Error = true;
        }
    } while (Error == true);
} while (On == false);
