//* Imprimir los numeros hasta 20.

Console.WriteLine("Numeros Naturales hasta el 20:");
for (int i = 1; i <= 20; i++)
{

  Console.WriteLine(i);

}

Console.WriteLine();

//* Imprimir los numeros impares
//? Para llegar al 20 en numeros impares +2, la variable i puede valer 0 o 2.

Console.WriteLine("Numeros Impares hasta el 20:");
for (int i = 2; i <= 20; i = i + 2)
{

  Console.WriteLine(i);

}

Console.WriteLine();

//* Podemos realizar la suma de los numeros pares.

int suma = 0;
for (int i = 1; i <= 10; i = i + 2)
{

  suma = suma + i;

}
Console.WriteLine("La suma es: " + suma);
Console.ReadKey();
