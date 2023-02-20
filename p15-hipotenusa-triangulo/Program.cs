//Calcular la hipotenusa de un triangulo

double lado1, lado2, hipotenusa;

Console.Clear();
Console.WriteLine("Ingrese el primer lado del triángulo:");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo lado del triángulo:");
lado2 = double.Parse(Console.ReadLine());

hipotenusa = Math.Sqrt(Math.Pow(lado1, 2) + Math.Pow(lado2, 2));

Console.WriteLine("La hipotenusa del triángulo es: " + hipotenusa);
