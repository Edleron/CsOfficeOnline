using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Concrete;

namespace OfficeOnline.Business.Abstract
{
    public interface IExpenseService
    {
        List<Expense> GetAll();

        List<Expense> GetOwnerAndSpecificCategories(int ownerID, int categoryID);


        void Add(Expense expense);

        void Update(Expense expense);

        void Delete(Expense expense);

        List<Expense> GetAllDateTimeList (string dateTimef1, string dateTimef2, int ownerID, int categoryID);

        /*
        List<Expense> GetPersonsByCetegory(int categoryID);

        List<Expense> GetExpensesByProductName(string ExpensesName);
        */

    }
}
