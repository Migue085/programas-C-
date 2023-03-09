// Imprmir los numeros del 1 al 100

int c,n,p;
c=1;
Console.Clear();
Console.Write("\nHasta donde quiere llegar ?");
n = int.Parse(Console.ReadLine());
Console.Write("\nPaso ?");
p = int.Parse(Console.ReadLine());
while( c <= n ) {
Console.Write($"{c} ");
c+=p;
}
Console.WriteLine("\nProceso terminado ...");