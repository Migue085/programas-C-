int opcion;
 Console.Clear();
        do {
            Console.WriteLine("1. Convertir de pulgadas a centímetros");
            Console.WriteLine("2. Convertir de metros a pies");
            Console.WriteLine("0. Salir");

            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    Console.Write("Introduce la longitud en pulgadas: ");
                    double pulgadas = double.Parse(Console.ReadLine());

                    double centimetros = PulgadasACentimetros(pulgadas);

                    Console.WriteLine("{0} pulgadas son {1} centímetros.", pulgadas, centimetros);
                    break;
                case 2:
                    Console.Write("Introduce la longitud en metros: ");
                    double metros = double.Parse(Console.ReadLine());

                    double pies = MetrosAPies(metros);

                    Console.WriteLine("{0} metros son {1} pies.", metros, pies);
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
    

    static double PulgadasACentimetros(double pulgadas) {
        return pulgadas * 2.54;
    }

    static double MetrosAPies(double metros) {
        return metros * 3.281;
    }