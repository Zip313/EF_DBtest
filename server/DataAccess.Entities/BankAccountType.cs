using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BankAccountType : IEntity
    {
        public int Id { get; set; }
        public string TypeName { get; set; } 
    }
}
