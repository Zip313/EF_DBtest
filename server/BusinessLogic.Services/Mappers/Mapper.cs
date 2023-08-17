using BusinessLogic.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Mappers
{
    internal static class Mapper
    {
        public static ClientDto ClientToDto(Client client)
        {
            return new ClientDto()
            {
                LastName = client.LastName,
                FirstName = client.FirstName,
                MiddleName = client.MiddleName,
                AccountDtos = client.BankAccounts is null
                        ?new List<AccountDto>()
                        : client.BankAccounts.Select(a => new AccountDto()
                        {
                            AccountType = a.AccountType.TypeName,
                            AliasName = a.AliasName,
                            Balance = a.Balance,
                            Currency = a.Currency.CurrencyName
                        })
             };
        }

        public static Client DtoToClient(ClientDto clientDto)
        {
            return new Client()
            {
                LastName = clientDto.LastName,
                FirstName = clientDto.FirstName,
                MiddleName = clientDto.MiddleName,
                BankAccounts = new List<BankAccount>()
            };
        }
    }
}
