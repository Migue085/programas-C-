Console.Clear();
Console.Write("Introduce un número del 1 al 7: ");
        int numero = int.Parse(Console.ReadLine());

        string dia = ObtenerDia(numero);

        Console.WriteLine("El día correspondiente es: " + dia);
    

    static string ObtenerDia(int numero) {
        switch (numero) {
            case 1:
                return "Lunes";
            case 2:
                return "Martes";
            case 3:
                return "Miércoles";
            case 4:
                return "Jueves";
            case 5:
                return "Viernes";
            case 6:
                return "Sábado";
            case 7:
                return "Domingo";
            default:
                throw new ArgumentException("El número debe estar entre 1 y 7.");
        }
    }