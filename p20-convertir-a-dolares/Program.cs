// Dada una cantidad en pesos y la cotización del dólar, se desea obtener el equivalente en dólares.

double pesos, dolar, cot;

Console.Clear();
Console.WriteLine("Ingrese la cantidad en pesos:");
pesos = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cotización del dólar:");
dolar = 18.3970;

cot = pesos / dolar;

Console.WriteLine("Equivalente en dólares: " + cot);
