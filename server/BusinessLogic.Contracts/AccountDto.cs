using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Contracts
{
    public class AccountDto
    {
        public string AccountType { get; set; }
        public string AliasName { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
    }
}
