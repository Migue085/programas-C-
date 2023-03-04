/*Dado el nombre del estudiante, sexo (h/m), su edad y tres calificaciones, decidir si el estudiante es aceptado. La
Universidad Kitty Kat SA es solo para mujeres mayores de 21 años con un promedio de entre 8 y 9.5.*/

Console.WriteLine("Ingrese el nombre del estudiante:");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el sexo (h/m):");
    string sexo = Console.ReadLine();

    Console.WriteLine("Ingrese la edad:");
    int edad = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la primera calificación:");
    double calificacion1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda calificación:");
    double calificacion2 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera calificación:");
    double calificacion3 = Double.Parse(Console.ReadLine());

    double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;

    if (sexo == "m" && edad > 21 && promedio >= 8 && promedio <= 9.5) {
      Console.WriteLine(nombre + " ha sido aceptada en la Universidad Kitty Kat SA.");
    } else {
      Console.WriteLine(nombre + " no cumple con los requisitos para ingresar a la Universidad Kitty Kat SA.");
    }
