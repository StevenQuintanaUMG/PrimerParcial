uint N = 0;
uint suma = 0;

Console.WriteLine("------------------- BIENVENIDO AL PROGRAMA :) ----------------------");

//1. Solicitar un entero positivo mayor que 0
while (N <= 0)
{
    try
    {
        Console.WriteLine("\nEscriba un numero entero positivo mayor a 0");
        N = Convert.ToUInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("\nERROR <---- El numero no es un entero positivo, vuelva a escribirlo");
    }
}

//3. Calcular la suma de los primeros N enteros positivos
for (uint i = 1; i <= N; i++)
{
   suma += i;
}


//4. Imprimir todos los numeros enteros positivos menores o iguales a N
Console.WriteLine("\nNumeros enteros positivos menores o iguales que N: ");
for (uint i = 1; i <= N; i++)
{
    Console.Write(i + ", ");
}

//5. Imprimir los numeros enteros positivos impares menores o iguales a N
Console.WriteLine("\n\nNumeros enteros positivos impares menores o iguales a N: ");
for (uint i = 1; i <= N; i++)
{
    if (i % 2 != 0)
    {
        Console.Write(i + ", ");
    }
}

//6. Imprimir tabla de multiplicar de N desde el 1 hasta el 10
Console.WriteLine("\n\nTabla de multiplicar del numero " + N);
for (uint i = 1; i <= 10; i++)
{
    Console.WriteLine(N + " x " + i + " = " + N*i);    
}

//7. Imprimir la secuencia de numeros enteros positivos que comienzan en N y se incrementa en 2 hasta 20
if(N <= 20)
{
    Console.WriteLine("\nSecuencia de numeros enteros positivos desde N incrementandose en 2 hasta que sea mayor que 20");
    for (uint i = N; i <= 20; i += 2)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("\n-------El numero es mayor o igual que 20 por lo que no se imprimira la secuencia-------");
}

//8. Imprimir la variable suma
Console.WriteLine("\n\nLa suma de los primeros N numeros enteros positivos es: " + suma);
