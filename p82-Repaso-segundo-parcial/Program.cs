double[] arreglo = new double[5];
        int opcion;
Console.Clear();
        do
        {
            Console.WriteLine("\n--- Menú de opciones ---");
            Console.WriteLine("1. Leer elementos en un arreglo");
            Console.WriteLine("2. Mostrar los elementos de un arreglo");
            Console.WriteLine("3. Buscar el elemento mayor del arreglo");
            Console.WriteLine("4. Buscar el elemento menor del arreglo");
            Console.WriteLine("5. Calcular suma y promedio del arreglo");
            Console.WriteLine("6. Buscar un elemento en el arreglo");
            Console.WriteLine("0. Salir del programa");
            Console.Write("\nIngrese la opción deseada: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    LeerArreglo(arreglo);
                    break;
                case 2:
                    MostrarArreglo(arreglo);
                    break;
                case 3:
                    BuscarMayor(arreglo);
                    break;
                case 4:
                    BuscarMenor(arreglo);
                    break;
                case 5:
                    CalcularSumaPromedio(arreglo);
                    break;
                case 6:
                    BuscarElemento(arreglo);
                    break;
                case 0:
                    Console.WriteLine("\nHasta luego.");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    static void LeerArreglo(double[] arreglo)
    {
        Console.WriteLine("\nIngrese los elementos del arreglo:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            arreglo[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nArreglo leído exitosamente.");
    }
    static void MostrarArreglo(double[] arreglo)
    {
        Console.WriteLine("\nLos elementos del arreglo son:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine($"Elemento {i + 1}: {arreglo[i]}");
        }
    }
    static void BuscarMayor(double[] arreglo)
    {
        double mayor = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] > mayor)
            {
                mayor = arreglo[i];
            }
        }
        Console.WriteLine($"\nEl elemento mayor del arreglo es: {mayor}");
    }
    static void BuscarMenor(double[] arreglo)
    {
        double menor = arreglo[0];
        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] < menor)
            {
                menor = arreglo[i];
            }
        }
        Console.WriteLine($"\nEl elemento menor del arreglo es: {menor}");
    }
    static void CalcularSumaPromedio(double[] arreglo)
    {
        double suma = 0;

        for (int i = 0; i < arreglo.Length; i++)
        {
            suma += arreglo[i];
        }

        double promedio = suma / arreglo.Length;

        Console.WriteLine($"\nLa suma de los elementos del arreglo es: {suma}");
        Console.WriteLine($"El promedio de los elementos del arreglo es: {promedio}");
    }
static void BuscarElemento(double[] arreglo)
{
    Console.Write("\nIngrese el elemento a buscar: ");
    double elemento = double.Parse(Console.ReadLine());

    bool encontrado = false;

    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == elemento)
        {
            Console.WriteLine($"\nEl elemento {elemento} se encuentra en la posición {i+1} del arreglo.");
            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine($"\nEl elemento {elemento} no se encuentra en el arreglo.");
    }
}