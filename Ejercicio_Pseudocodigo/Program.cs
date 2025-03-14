float[] ventas = new float[7];
String[] day = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("                     Bienvenido          ");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Ingrese las ventas de la semana: \n");
for (int i = 0; i < ventas.Length; i++)
{
  Console.Write(day[i] + "[" + i + "]: ");
  ventas[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine("-----------------------------------------------------");

Console.WriteLine("Ventas de la semana semana: \n");
for (int i = 0; i < ventas.Length; i++)
{
  Console.WriteLine(day[i] +"[" + i + "] -> " + ventas[i] + "$");
}

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Ventas mayores a 2000$: \n");
float total = 0;
float totalS = 0;
int Count = 0;

for(int i = 0; i < ventas.Length; i++){
  if(ventas[i] > 2000){
    Console.WriteLine(day[i] + "["+i+"] -> " + ventas[i] + "$");
    Count = Count + 1;
    total = total + ventas[i];
  }
  totalS = totalS + ventas[i];
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Fueron " + Count + " ventas mayores a 2000$");
Console.WriteLine("Total de ventas mayores a 2000$ -> " + total + "$");
Console.WriteLine("Total de ventas de la semana -> " + totalS + "$");
Console.WriteLine("-----------------------------------------------------");

Console.ReadKey();