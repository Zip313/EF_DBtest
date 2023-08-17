using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Currency:IEntity
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
    }
}
