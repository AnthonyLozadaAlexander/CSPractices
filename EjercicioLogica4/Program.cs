using System.Security.AccessControl;

float piezasTemp = 0.0f, total = 0.0f, piezas = 0.0f;
string respuesta = "";
bool Continuar = true;
bool On = true;
string invalidPiezas;
do
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("             BIENVENIDO");
    Console.WriteLine("---------------------------------");
    do
    {
        Console.WriteLine("Ingrese la cantidad de piezas que compra");
        Console.Write("-> ");
        invalidPiezas = Console.ReadLine();

        if (!float.TryParse(invalidPiezas, out piezasTemp))
        {
            Console.WriteLine("\nError: Debe Ingresar Un Numero De Piezas A Comprar");
            Console.WriteLine("Presione una tecla para continuar...");
            
            if(Console.ReadKey(true).Key != ConsoleKey.NoName)
            {
                Console.Clear();
                On = true;
            }
        }
        else
        {
            piezas = piezasTemp;
            if (piezas <= 0)
            {
                Console.WriteLine("\nError: Debe Ingresar Un Numero De Piezas A Comprar Mayor A 0");
                Console.WriteLine("Presione una tecla para continuar...");
                if(Console.ReadKey(true).Key != ConsoleKey.NoName)
                {
                    Console.Clear();
                    On = true;
                }
            }
            else
            {
                Console.WriteLine("\nCantidad De Piezas Ingresadas: " + piezas + "\n");

                if (piezas > 50 && piezas <= 100)
                {
                    total = piezas * 4.5f;
                    On = false;
                }
                else if (piezas > 100)
                {
                    total = piezas * 4.0f;
                    On = false;
                }
                else if (piezas <= 50)
                {
                    total = piezas * 5.0f;
                    On = false;
                }
            }
        }
    } while (On == true);

    do
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Cantidad De Piezas: " + piezas);
        Console.WriteLine("Total A Pagar: " + total);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("¿Desea Continuar? (S/N)");
        Console.Write("-> ");
        respuesta = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(respuesta))
        {
            Console.WriteLine("\nError: Debe Ingresar Una Respuesta\n");
        }
        else if(respuesta.Equals("s", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();
            Continuar = false;
            break;
        }
        else if (respuesta.Equals("n", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nGracias Por Usar Nuestro Programa");
            Continuar = true;
            break;
        }
        else
        {
            Console.WriteLine("\nError: Debe Ingresar Una Respuesta Valida\n");
        }
    } while (true);

} while (Continuar == false);
