// Control bancario
Console.WriteLine("\nProbando la clase CuentaBancaria:\n");
CuentaBancaria cuenta = new CuentaBancaria(5000);
Console.WriteLine($"Saldo inicial : {cuenta.Saldo}");
cuenta.Deposita(10000);
Console.WriteLine($"Saldo deposito: {cuenta.Saldo}");
bool retiro = cuenta.Retira(40);
if(retiro)
Console.WriteLine($"Saldo retiro : {cuenta.Saldo}");
else
Console.WriteLine("No se pudo retirar, saldo insuficiente");

Console.WriteLine("\nProbando la clase Cliente:\n");
Cliente cliente1 = new Cliente("Juan Carlos","Perez");
cliente1.Cuenta = cuenta;
Console.WriteLine($"Datos cliente: {cliente1.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Maria","Lopez");
cliente2.Cuenta = new CuentaBancaria(10000000);
cliente2.Cuenta.Retira(50000);
Console.WriteLine($"Datos cliente: {cliente2.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente2.Cuenta.Saldo}");

Console.WriteLine("\nProbando la clase Banco:\n");
Banco mibanco = new Banco("Banco santa","isabelica 234");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente("Solo vino","Solo se fue");
cliente3.Cuenta = new CuentaBancaria(10000);
mibanco.AgregarCliente(cliente3);
mibanco.Clientes[0].Cuenta.Deposita(12000);
mibanco.Clientes[1].Cuenta.Retira(1000);
mibanco.Clientes[2].Cuenta.Deposita(100000);
Console.WriteLine("\n Resumen de banco\n");
Console.WriteLine($"Banco: {mibanco.ToString()}");
foreach(Cliente cl in mibanco.Clientes) {
Console.WriteLine($"Cliente: {cl.ToString()}");
Console.WriteLine($"Saldo : {cl.Cuenta.Saldo}");
}