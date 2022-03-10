using ExercicioPOOContratos.Enrtities;
using ExercicioPOOContratos.Services;
using System.Globalization;

Console.WriteLine("DADOS DO CONTRATO");
Console.Write("Numero: ");
int numeroDoContrato = int.Parse(Console.ReadLine());
Console.Write("Data (dd/MM/yyyy): ");
DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
Console.Write("Valor do Contrato: ");
double valorContrato = double.Parse(Console.ReadLine());

Contrato contrato = new Contrato(numeroDoContrato,dataContrato,valorContrato);

Console.Write("Insira o numero de prestações: ");
int prestacoes = int.Parse(Console.ReadLine());

ContratoService servicoDeContrato = new ContratoService(new PaypalService());
servicoDeContrato.ProcessarContrato(contrato,prestacoes);

Console.WriteLine("\nPRESTAÇÕES:");
foreach (Prestacao item in contrato.Prestacoes)
{
    Console.WriteLine(item);
}