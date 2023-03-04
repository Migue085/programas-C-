/* Un usuario puede elegir un tamaño de pizza ( chica - $5, mediana $10, grande $20 ) , luego elige la cantidad, si la
compra es menor a 2000 no tiene descuento, mayor a 2000 tiene un descuento de 15%. Diseñe un programa que
permita procesar la solicitud e imprimir: tamaño de la compra, cantidad comprada, total compra, descuento, total de
compra con descuento.*/


Console.WriteLine("Hello, World!");
 Console.WriteLine("Tamaños de pizza:");
    Console.WriteLine("Chica - $5");
    Console.WriteLine("Mediana - $10");
    Console.WriteLine("Grande - $20");

    Console.WriteLine("Ingrese el tamaño de la pizza (chica/mediana/grande):");
    string tamaño = Console.ReadLine().ToLower();

    Console.WriteLine("Ingrese la cantidad de pizzas que desea comprar:");
    int cantidad = Int32.Parse(Console.ReadLine());

    int precio = 0;
    switch (tamaño) {
      case "chica":
        precio = 5;
        break;
      case "mediana":
        precio = 10;
        break;
      case "grande":
        precio = 20;
        break;
      default:
        Console.WriteLine("Tamaño de pizza inválido.");
        return;
    }

    int totalCompra = precio * cantidad;

    double descuento = 0.0;
    if (totalCompra > 2000) {
      descuento = 0.15;
    }

    double totalConDescuento = totalCompra - (totalCompra * descuento);

    Console.WriteLine("Tamaño de pizza: " + tamaño);
    Console.WriteLine("Cantidad comprada: " + cantidad);
    Console.WriteLine("Total de compra: $" + totalCompra);
    Console.WriteLine("Descuento: " + (descuento * 100) + "%");
    Console.WriteLine("Total de compra con descuento: $" + totalConDescuento);