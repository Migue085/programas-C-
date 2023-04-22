Console.Clear();
Console.Write("Introduce un ángulo entre 0 y 360 grados: ");
        int angulo = int.Parse(Console.ReadLine());

        string tipoAngulo = TipoDeAngulo(angulo);

        Console.WriteLine("El ángulo {0} grados es {1}.", angulo, tipoAngulo);

    static string TipoDeAngulo(int angulo) {
        string tipo = "";

        if (angulo < 90) {
            tipo = "agudo";
        } else if (angulo == 90) {
            tipo = "recto";
        } else if (angulo > 90 && angulo < 180) {
            tipo = "obtuso";
        } else if (angulo == 180) {
            tipo = "llano";
        } else if (angulo > 180 && angulo < 360) {
            tipo = "cóncavo";
        } else {
            tipo = "fuera de rango";
        }

        return tipo;
    }