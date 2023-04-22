int[] numeros = new int[4];
        Console.Clear(); 
        Console.WriteLine("Por favor, ingresa 4 números enteros:");

        for (int i = 0; i < 4; i++) {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int menor = numeros[0];
        for (int i = 1; i < 4; i++) {
            if (numeros[i] < menor) {
                menor = numeros[i];
            }
        }

        Console.WriteLine("El menor de los números ingresados es: " + menor);
        Console.ReadLine();