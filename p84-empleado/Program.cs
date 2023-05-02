// Instanciar y reservar espacio en memoria
Empleado empleado01 = new Empleado();
// Instanciar, luego reservar espacio en memoria
Empleado empleado02;
empleado02 = new Empleado();
Empleado empleado03 = new Empleado("El berna");
Empleado empleado04 = new Empleado("Benito",48);
Empleado empleado05 = new Empleado("panfilo",45);
// Aasigna los valores a la clase 
empleado01.Nombre = "Miguel";
empleado01.Edad = 22;
empleado02.Nombre = "Jose";
empleado02.Edad = 21;
// Invocar los métdos de la clase 
empleado01.ImprimirDatos();
empleado02.ImprimirDatos();
empleado03.ImprimirDatos();
empleado04.ImprimirDatos();
empleado05.ImprimirDatos();