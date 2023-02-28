// Administra el pago por estacionamiento de acuerdo a la Zona

int op;
float tasa,pago,imp,total;

Console.Clear();
Console.WriteLine("Administra el pago por estacionamiento de acuerdo a la zona\n");
Console.WriteLine("1.-Estacionamiento Tacuba 3%");
Console.WriteLine("2.-Estacionamiento Portales 5%");
Console.WriteLine("3.-Estacionamiento Conquistadores 10%");
Console.WriteLine("4.-Estacionamiento Pajaros Cidos 15%");
Console.Write("Elige opcion :");
op = int.Parse(Console.ReadLine());
Console.Write("Pago efectuado ?"); pago = float.Parse(Console.ReadLine());
tasa=0.0f;
switch(op){
    case 1 : tasa = 0.03f;break;
    case 2 : tasa = 0.05f;break;
    case 3 : tasa = 0.10f;break;
    case 4 : tasa = 0.15f;break;
} 

imp = pago * tasa;
total = pago + imp;
string salida = string.Format($"Eligiste el estacionamiento {op}" + 
         $"Pagaste {pago} por el tiempo de uso \n"+ 
         $"corresponde un impuesto de {imp:n2}\n" +
         $"El pago total es de {total:n2} \n");
Console.WriteLine(salida);