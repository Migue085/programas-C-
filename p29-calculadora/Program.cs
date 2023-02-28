// Efectua operaciones matamaticas basicas 

double n1,n2;
char op;

Console.Clear();
Console.WriteLine("Efectua operaciones matamaticas basicas con 2 numeros\n");
Console.WriteLine("Dame el numero 1:"); n1 = double.Parse(Console.ReadLine()); 
Console.WriteLine("Dame el numero 2:"); n2 = double.Parse(Console.ReadLine()); 
Console.WriteLine("Operacion (+ - * / ^ ):"); 
op = Console.ReadLine()[0];

switch(op){
    case '+': Console.WriteLine($"n1+n2={n1 + n2}");break;
    case '-': Console.WriteLine($"n1-n2={n1 - n2}");break;
    case '*': Console.WriteLine($"n1*n2={n1 * n2}");break;
    case '/': Console.WriteLine($"n1/n2={n1 / n2}");break;
    case '^': Console.WriteLine($"n1/n2={Math.Pow(n1,n2)}");break;
    default : Console.WriteLine("operacion invalida....");break;
}