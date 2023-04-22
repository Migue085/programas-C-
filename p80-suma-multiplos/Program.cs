int opcion;
Console.Clear();
        do {
            Console.WriteLine("1. Sumar múltiplos de 3");
            Console.WriteLine("2. Sumar múltiplos de 4");
            Console.WriteLine("0. Salir");

            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.Write("Introduce el valor inicial del rango: ");
                    int ini1 = int.Parse(Console.ReadLine());
                    Console.Write("Introduce el valor final del rango: ");
                    int fin1 = int.Parse(Console.ReadLine());

                    int suma1 = SumaMultiplos(ini1, fin1, 3);

                    Console.WriteLine("La suma de los múltiplos de 3 en el rango [{0}, {1}] es: {2}", ini1, fin1, suma1);
                    break;
                case 2:
                    Console.Write("Introduce el valor inicial del rango: ");
                    int ini2 = int.Parse(Console.ReadLine());
                    Console.Write("Introduce el valor final del rango: ");
                    int fin2 = int.Parse(Console.ReadLine());

                    int suma2 = SumaMultiplos(ini2, fin2, 4);

                    Console.WriteLine("La suma de los múltiplos de 4 en el rango [{0}, {1}] es: {2}", ini2, fin2, suma2);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 0);

    static int SumaMultiplos(int ini, int fin, int constante) {
        int suma = 0;

        for (int i = ini; i <= fin; i++) {
            if (i % constante == 0) {
                suma += i;
            }
        }

        return suma;
    }