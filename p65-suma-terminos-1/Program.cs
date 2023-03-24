 Console.Write("¿Cuántos términos? ");
        int numTerminos = int.Parse(Console.ReadLine());

        double suma = 0.0;

        for (int i = 1; i <= numTerminos; i++) {
            suma += 1.0 / i;
            Console.Write("1/" + i);
            if (i < numTerminos) {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Suma " + suma);