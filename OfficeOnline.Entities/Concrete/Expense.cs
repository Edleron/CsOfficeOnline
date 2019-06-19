using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Abstract;

namespace OfficeOnline.Entities.Concrete
{
    public class Expense : IEntity
    {
        public int ExpenseId { get; set; }
        public string ExpenselName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Explanation { get; set; }
        public DateTime DateOperation { get; set; }
        public string ImagePath { get; set; }
        public int PersonId { get; set; }

    }
}
