// Calcula el area de un circulo

double area, radio;
Console.WriteLine("Calclando el area de un circulo");
Console.Write("Dame el radio >");
radio = double.Parse(Console.ReadLine());
area = Math.PI * Math.Pow(radio,2);
Console.WriteLine($"El circulo de radio {radio} tiene una area de {area}\n");
Console.WriteLine("El tipo de dato de las variables es:");

Console.WriteLine(radio.GetType());
Console.WriteLine(area.GetType());

