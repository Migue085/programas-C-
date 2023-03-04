// Dados tres números enteros, verificar cual es el mayor

Console.WriteLine("Ingrese el primer número: ");
    int num1 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Ingrese el segundo número: ");
    int num2 = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Ingrese el tercer número: ");
    int num3 = Int32.Parse(Console.ReadLine());

    int mayor = num1;

    if (num2 > mayor) {
      mayor = num2;
    }
    if (num3 > mayor) {
      mayor = num3;
    }

    Console.WriteLine("El número mayor es: " + mayor);