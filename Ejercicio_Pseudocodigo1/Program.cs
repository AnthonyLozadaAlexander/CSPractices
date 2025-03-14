float libras = 0, onzas = 0, libkg = 0, onzkg = 0, total = 0;
String valor = "";
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("                    Conversor De Peso                ");
Console.WriteLine("-----------------------------------------------------");
Console.Write("Digite las libras: ");
valor = Console.ReadLine();
libras = float.Parse(valor);
Console.Write("Digite las onzas: ");
onzas = float.Parse(Console.ReadLine());

libkg = libras * 0.454f; // 1 libra es igual a 0.454 kg
onzkg = onzas * 0.0283f; // 1 onza es igual a 0.0283 kg
total = (libkg + onzkg);

Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Libras: " + libras + " -> Kilogramos = " + libkg + "kg");
Console.WriteLine("Onzas: " + onzas + " -> Kilogramos = " + onzkg + "kg");
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Total de libras y onzas en kilogramos: " + total + "kg");

Console.ReadKey();