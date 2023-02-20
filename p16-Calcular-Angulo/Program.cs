//Se desea calcular el 3er ángulo de un triángulo dados los dos primeros ángulos del mismo.

double angulo1, angulo2, angulo3;

Console.Clear();
Console.WriteLine("Ingrese el primer ángulo del triángulo:");
angulo1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo ángulo del triángulo:");
angulo2 = double.Parse(Console.ReadLine());

angulo3 = 180 - angulo1 - angulo2;

Console.WriteLine("El tercer ángulo del triángulo es: " + angulo3);