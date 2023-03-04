/*Se desea calcular el promedio de 5 calificaciones introducidas por el usuario, luego evaluar el resultado e imprimir
un mensaje de acuerdo con el promedio obtenido:
• >0 y <= 6 Quedas reprobado
• >6 a <=7 Pasas de panzazo
• >7 y <=8 Muy bien, pues mejorar
• >8 y <=9 Excelente sigue así
• >9 y <=10 Perfecto tu esfuerzo valió la pena*/

double suma = 0;

for (int i = 1; i <= 5; i++) {
Console.WriteLine("Ingrese la calificación " + i + ":");
double calificacion = Double.Parse(Console.ReadLine());
suma += calificacion;
}

double promedio = suma / 5;
string mensaje = "";

if (promedio > 0 && promedio <= 6) {
mensaje = "Quedas reprobado";
} else if (promedio > 6 && promedio <= 7) {
mensaje = "Pasas de panzazo";
} else if (promedio > 7 && promedio <= 8) {
mensaje = "Muy bien, pues mejorar";
} else if (promedio > 8 && promedio <= 9) {
mensaje = "Excelente sigue así";
} else if (promedio > 9 && promedio <= 10) {
mensaje = "Perfecto tu esfuerzo valió la pena";
} else {
Console.WriteLine("Promedio inválido.");
return;
}

Console.WriteLine("El promedio es: " + promedio);
Console.WriteLine("Mensaje: " + mensaje);
