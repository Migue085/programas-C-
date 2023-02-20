//desea calcular el volumen de un cilindro dado su radio y altura

double radio, altura, volumen;
const double pi = 3.14159;

Console.Clear();
Console.WriteLine("Ingrese el radio del cilindro:");
radio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del cilindro:");
altura = double.Parse(Console.ReadLine());

volumen = pi * (radio * radio) * altura;

Console.WriteLine("El volumen del cilindro es: " + volumen);
