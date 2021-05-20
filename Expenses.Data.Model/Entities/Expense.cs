using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data.Model.Entities
{
    public class Expense
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public string UserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User User { get; set; }
    }
}
