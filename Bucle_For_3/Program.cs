//* Calcular el promedio de N calificaciones

int num;
double suma = 0;
Console.WriteLine("¿Cuantas calificaciones se van a promediar?");

num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
   Console.WriteLine("Escribe la Calificacion " + i);
   double calif = Convert.ToDouble(Console.ReadLine());
   suma = suma + calif;

}

double promedio = suma / num;
Console.WriteLine("El promedio es: " + promedio);
Console.ReadKey();

