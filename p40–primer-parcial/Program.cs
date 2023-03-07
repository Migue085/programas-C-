/*Se desea llevar el control de la inscripción a un evento académico de la Universidad Patito. Se especifica: Tipo
de usuario, paquete y cantidad.
• Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500
• Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900
Se debe calcular un subtotal de la venta sumando el precio del tipo de usuario más el precio de tipo de paquete, y
multiplicando por la cantidad solicitada.
Se otrgará un descuento siempre y cuando el subtotal sea mayor a 5,000 y de acuerdo a lo siguiente
• Es Alumno 20%
• Es Trabajador y un 10%
• Es Docente y un 5%
Al final mostrar un resumen con los datos calculados.*/

Console.Clear();
int usu, paq, cantidad;
double precioUsuario = 0, precioPaquete = 0, subtotal, descuento = 0, total;

Console.WriteLine("Bienvenido al sistema de inscripción de la Universidad Patito");
Console.WriteLine("Ingrese el tipo de usuario [1] Alumno, [2] Trabajador, [3] Docente:");
usu = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tipo de paquete [1] Solo conferencias, [2] Con eventos sociales, [3] Con kit de acceso:");
paq = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de paquetes que desea inscribir:");
cantidad = int.Parse(Console.ReadLine());

switch (usu){
case 1: precioUsuario = 100; break;
case 2: precioUsuario = 200; break;
case 3: precioUsuario = 500;break;
default: Console.WriteLine("Tipo de usuario inválido !!!!.");break;
}

switch (paq){
case 1: precioPaquete = 600;break;
case 2: precioPaquete = 800;break;
case 3: precioPaquete = 900;break;
default:Console.WriteLine("Tipo de paquete inválido !!!!.");break;
}

subtotal = (precioUsuario + precioPaquete) * cantidad;

if (subtotal > 5000){
switch (usu){
case 1:descuento = subtotal * 0.2;break;
case 2:descuento = subtotal * 0.1;break;
case 3:descuento = subtotal * 0.05;break;
default:Console.WriteLine("Tipo de usuario inválido!!!!!!!.");break;
}
}
total = subtotal - descuento;

Console.WriteLine("Resumen de la inscripción:");
Console.WriteLine("Tipo de usuario: {0}", usu);
Console.WriteLine("Precio del tipo de usuario: ${0}", precioUsuario);
Console.WriteLine("Tipo de paquete: {0}", paq);
Console.WriteLine("Precio del tipo de paquete: ${0}", precioPaquete);
Console.WriteLine("Cantidad: {0}", cantidad);
Console.WriteLine("Subtotal: ${0}", subtotal);
Console.WriteLine("Descuento: ${0}", descuento);
Console.WriteLine("Total: ${0}", total);