// Dada una cantidad en horas, calcular su equivalente en días, minutos y segundos, considerando que >
//• 1 día tiene 24 horas,
//• 1 hora tiene 60 minutos,
//• 1 minuto tiene 60 segundos

int horas, minutos, segundos, dias;

Console.Clear();
Console.WriteLine("Ingrese una cantidad de horas:");
horas = int.Parse(Console.ReadLine());

dias = horas / 24;
horas = horas % 24;
minutos = horas * 60;
segundos = minutos * 60;

Console.WriteLine("Equivalente en días: " + dias);
Console.WriteLine("Equivalente en minutos: " + minutos);
Console.WriteLine("Equivalente en segundos: " + segundos);

