// Dados tres números enteros, verificar si son consecutivos (9,10,11) y mandar mensaje confirmándolo, si no lo son
//(1,4,6) mandar mensaje de error.

int num1,num2,num3;

Console.Clear();
Console.WriteLine("Introduzca el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca el segundo numero");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca el tercer numero");
num3 = int.Parse(Console.ReadLine());

if(num1 + 1 == num2 && num2 + 1 == num3){
    Console.WriteLine("Los Numeros son consecutivos!");
}else{
    Console.WriteLine("Lo siento, los numeros no son consecutivos");
}