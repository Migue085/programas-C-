// Imprmir los numeros del 100 al 1

int c,n,p;


Console.Clear();
Console.Write("\nHasta donde quiere llegar ?");
n = int.Parse(Console.ReadLine());
Console.Write("\nPaso ?");
p = int.Parse(Console.ReadLine());

c=n;

while( c >=1 ) {
Console.Write($"{c} ");
c-=p;
}
Console.WriteLine("\nProceso terminado ...");
