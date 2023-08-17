using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BankAccount:IEntity
    {
        public int Id { get; set; }
        public virtual BankAccountType AccountType { get; set; }
        public string AliasName { get; set; }
        public decimal Balance { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Client Client { get; set; }

    }
}
