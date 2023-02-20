//Se desea convertir una temperatura de grados fahrenheit a grados celsius
double fahrenheit, celsius;

Console.Clear();
Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
fahrenheit = double.Parse(Console.ReadLine());

celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine("La temperatura en grados Celsius es: " + celsius);