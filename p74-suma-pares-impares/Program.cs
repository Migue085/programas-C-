// Imprime pares o impares y su suma, usando función

Console.Clear();
 int cantidadNumeros;
 int numero;
            int sumaPares = 0;
            int sumaImpares = 0;

            Console.Write("Ingrese la cantidad de números a sumar: ");
            cantidadNumeros = int.Parse(Console.ReadLine());

 for (int i = 1; i <= cantidadNumeros; i++)
    {
        Console.Write("Ingrese el número " + i + ": ");
        numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
    {
        sumaPares += numero;
    }
else
    {
        sumaImpares += numero;
    }
}
Console.WriteLine("La suma de los números pares es: " + sumaPares);
Console.WriteLine("La suma de los números impares es: " + sumaImpares);
Console.ReadLine();