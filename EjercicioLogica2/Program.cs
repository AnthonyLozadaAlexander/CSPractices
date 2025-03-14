float compra=0, total=0, descuento=0, montoFinal = 0;
bool On = true;
string invalidEdad = "";
do
{
    Console.Clear();
    Console.WriteLine("----------BIENVENIDO-----------");
    Console.WriteLine("Ingrese su Nombre");
    Console.Write("-> ");
    string nombre = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit))
    {
        Console.WriteLine("Nombre inválido. No debe contener números ni estar vacío. Por favor, inténtelo nuevamente.");
        On = true;
    }
    else
    {
        bool continuar = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Ingrese su Edad");
            Console.Write("-> ");
            invalidEdad = Console.ReadLine();
            if (!Int32.TryParse(invalidEdad, out int edad))
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine("Error: Ingrese una Edad");
                Console.WriteLine("-----------------------\n");
                continuar = true;
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Datos Ingresados Correctamente");
                Console.WriteLine("------------------------------");
                On = false;
                continuar = false;
            }
        } while (continuar == true);
    }
}while(On == true);