using AppHW_DB.DI;
using BusinessLogic.Contracts;
using BusinessLogic.Services;
using DataAccess.Entities;
using Microsoft.Extensions.DependencyInjection;

IServiceProvider serviceProvider = DIFactory.RegisterDI();

 var clientService = serviceProvider.GetService<ClientService>();

Console.WriteLine("Введите имя нового клиента");
string lastName = Console.ReadLine();
clientService.CreateClient(new ClientDto() { LastName = lastName, FirstName = "New user" });

var clients = clientService.GetAllClients().ToList();
foreach (var client in clients)
{
    Console.WriteLine($"{client.LastName} {client.FirstName} {client.MiddleName} " +
        $"счет:{string.Join(',', client.AccountDtos.Select(a => $" {a.AliasName} {a.Balance} {a.Currency}"))}");
}






Console.ReadKey();