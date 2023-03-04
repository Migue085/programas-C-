// Dado un número entero entre 1 y 6 que corresponde a un continente del mundo, escribir su nombre: 1 Asia, 2 África,
//3 América del Norte, 4 América del Sur, 5 Antártida, 6 Europa . Si el número no está en el rango especificado, mostrar
//un mensaje de error.
int dia;

Console.Clear();
Console.WriteLine("Dado un numero entre 1 y 7 imprime el contineneye en que vives \n");
Console.WriteLine("Dame el numero del 1 al 6:"); dia = int.Parse(Console.ReadLine());
switch(dia){
    case 1 : Console.WriteLine("Asia"); break;
    case 2 : Console.WriteLine("Africa"); break;
    case 3 : Console.WriteLine("America del norte"); break;
    case 4 : Console.WriteLine("America del sur"); break;
    case 5 : Console.WriteLine("Antartida"); break;
    case 6 : Console.WriteLine("Europa"); break;
    default : Console.WriteLine("El continente en que vives !!!"); break;
}
Console.WriteLine("\n Proceso Terminado ...");
