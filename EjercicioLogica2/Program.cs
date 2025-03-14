using System.Threading.Channels;

float monto = 0, total = 0, descuento = 0, montoFinal = 0;
bool On = true;
int Edad = 0;
string sexo = "";
string invalidMonto = "";
string invalidEdad = "";
string nombre = "";
do
{
    Console.WriteLine("\n----------BIENVENIDO-----------");
    Console.WriteLine("Ingrese su Nombre");
    Console.Write("-> ");
    nombre = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(nombre) || nombre.Any(char.IsDigit))
    {
        Console.WriteLine("Error: No debe contener números ni estar vacío. Por favor, inténtelo nuevamente.");
        On = true;
    }
    else
    {
        bool continuar = true;
        do
        {
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
                Edad = edad;
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("Datos Ingresados Correctamente");
                Console.WriteLine("------------------------------\n");
                bool salir = false;
                do
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Ingrese su genero");
                    Console.WriteLine("M = Masculino");
                    Console.WriteLine("F = Femenino");
                    Console.WriteLine("--------------------------------");
                    Console.Write("-> ");
                    sexo = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(sexo) || sexo.Any(char.IsDigit))
                    {
                        Console.WriteLine(
                            "\nError: No debe contener números ni estar vacío. Por favor, inténtelo nuevamente.\n");
                        salir = false;
                    }
                    else if (sexo == "M" || sexo == "m" || sexo == "F" || sexo == "f")
                    {
                        Console.WriteLine("\n------------DATOS INGRESADOS CORRECTAMENTE------------");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("Nombre -> " + nombre);
                        Console.WriteLine("Edad -> " + Edad);
                        Console.WriteLine("Sexo -> " + sexo);
                        Console.WriteLine("-----------------------------------------------\n");
                        salir = true;
                        continuar = false;
                        On = false;
                    }
                    else
                    {
                        Console.WriteLine("\nError: Ingrese un genero");
                        salir = false;
                    }
                } while (salir == false);
            }
        } while (continuar == true);
    }
} while (On == true);

do
{
    Console.WriteLine("Ingrese el monto de su compra");
    Console.Write("-> ");
    invalidMonto = Console.ReadLine();

    if (!float.TryParse(invalidMonto, out monto))
    {
        Console.WriteLine("\n--------------------------------------");
        Console.WriteLine("Error: Debe Ingresar Un Monto Numerico");
        Console.WriteLine("--------------------------------------\n");
        On = true;
    }
    else if (monto <= 0)
    {
        Console.WriteLine("\n--------------------------------------------");
        Console.WriteLine("Error: El monto no puede ser menor o igual a 0");
        Console.WriteLine("----------------------------------------------\n");
        On = true;
    }
    else
    {
        Console.WriteLine("\n--------------------------------------");
        Console.WriteLine("Monto Ingresados Correctamente");
        Console.WriteLine("----------------------------------------\n");

        if (monto >= 300 && monto < 500)
        {
            descuento = monto * 0.30f; // porcentaje del descuento
            total = monto - descuento;
            montoFinal = total;
            On = false;
        }
        else if (monto >= 500 && monto < 1000)
        {
            descuento = monto * 0.30f; // porcentaje del descuento
            total = monto - descuento;
            montoFinal = total;
            On = false;
        }
        else if (monto < 300)
        {
            descuento = monto * 0.10f; // porcentaje del descuento
            total = monto - descuento;
            montoFinal = total;
            On = false;
        }
    }
} while (On == true);

float descuentoEdad = 0;
float montoEdadFinal = 0;
if ((sexo.Equals("F", StringComparison.OrdinalIgnoreCase)) && (Edad >= 50 && Edad <= 120))
{
    descuentoEdad = total * 0.10f;
    montoEdadFinal = montoFinal - descuentoEdad;
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("MontoInicial: " + monto);
    Console.WriteLine("Descuento: " + descuento);
    Console.WriteLine("DescuentoEdad: " + descuentoEdad);
    Console.WriteLine("Total a Pagar: " + montoEdadFinal);
    Console.WriteLine("-----------------------------------------------");
}
else if (sexo.Equals("M", StringComparison.OrdinalIgnoreCase) && (Edad >= 60 && Edad <= 120))
{
    descuentoEdad = total * 0.10f;
    montoEdadFinal = montoFinal - descuentoEdad;
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("MontoInicial: " + monto);
    Console.WriteLine("Descuento: " + descuento);
    Console.WriteLine("DescuentoEdad: " + descuentoEdad);
    Console.WriteLine("Total a Pagar: " + montoEdadFinal);
    Console.WriteLine("-----------------------------------------------");
}
else
{
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("MontoInicial: " + monto);
    Console.WriteLine("Descuento: " + descuento);
    Console.WriteLine("Total a Pagar: " + montoFinal);
    Console.WriteLine("-----------------------------------------------");
}

Console.ReadKey();