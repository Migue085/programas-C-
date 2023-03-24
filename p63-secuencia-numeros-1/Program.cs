 Console.Write("¿Cuántos renglones? ");
        int numRenglones = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numRenglones; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }