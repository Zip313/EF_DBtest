using DataAccess.Entities;
using DataAccess.Repositories.Abstarctions;
using EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Implementations
{
    public class ClientRepository : IClientRepository
    {
        BankContext bankContext;
        DbSet<Client> clients;

        public ClientRepository(BankContext bankContext)
        {
            this.bankContext = bankContext;
            this.clients = bankContext.Clients;
        }

        public void Create(Client item)
        {
            clients.Add(item);
            bankContext.SaveChanges();
        }

        public IEnumerable<Client> Get()
        {
            return clients.Include(p=>p.BankAccounts).ThenInclude(p=>p.AccountType).Include(p=>p.BankAccounts).ThenInclude(p=>p.Currency);
        }

        public IEnumerable<Client> Get(Func<Client, bool> predicate)
        {
            return clients.Include(p => p.BankAccounts).ThenInclude(p => p.AccountType).Include(p => p.BankAccounts).ThenInclude(p => p.Currency).Where(predicate);
        }

        public void Remove(Client item)
        {
            clients.Remove(item);
            bankContext.SaveChanges();
        }

        public void Update(Client item)
        {
            clients.Update(item);
            bankContext.SaveChanges();
        }
    }
}
