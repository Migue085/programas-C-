Console.Write("¿Cuántos términos? ");
        int cantidad = int.Parse(Console.ReadLine());
        string cadena = "";
        int suma = 0;
        for (int i = 0; i < cantidad; i++)
        {
            int termino = int.Parse(new string('1', i + 1));
            cadena += termino.ToString();
            suma += termino;
            if (i != cantidad - 1)
            {
                cadena += "+";
            }
        }
        Console.WriteLine(cadena);
        Console.WriteLine("suma " + suma);