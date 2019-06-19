using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Business.Abstract;
using OfficeOnline.DataAccess.Abstract;
using OfficeOnline.Entities.Concrete;

namespace OfficeOnline.Business.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        #region Property
        private IExpenseDal _expenseDal;
        #endregion

        #region Construtors
        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }
        #endregion


        #region Operation
        public void Add(Expense expense)
        {
            _expenseDal.Add(expense);
        }

        public void Delete(Expense expense)
        {
            try
            {
                _expenseDal.Delete(expense);
            }
            catch (Exception)
            {

                throw new Exception("Silme İşlemi Gerçekleştirilemedi");
            }
        }

        public void Update(Expense expense)
        {
            _expenseDal.Update(expense);
        }

        public List<Expense> GetAll()
        {
            return _expenseDal.GetAll();
        }

        //Belirlenen Kategoride & Sahip olan Kullanıcı
        public List<Expense> GetOwnerAndSpecificCategories(int ownerID, int categoryID)
        {
            return _expenseDal.GetAll(p => p.PersonId == ownerID && p.CategoryId == categoryID);
        }

        public List<Expense> GetAllDateTimeList(string dateTimef1, string dateTimef2, int ownerID, int categoryID)
        {
            try
            {
                string[] s1 = dateTimef1.Split(' ');
                string[] explanationS1 = s1[0].Split('/');
                DateTime dateTimeStart = new DateTime(Convert.ToInt32(explanationS1[2]), Convert.ToInt32(explanationS1[0]), Convert.ToInt32(explanationS1[1]));

                string[] s2= dateTimef2.Split(' ');
                string[] explanationS2 = s2[0].Split('/');
                DateTime dateTimeFinaly = new DateTime(Convert.ToInt32(explanationS2[2]), Convert.ToInt32(explanationS2[0]), Convert.ToInt32(explanationS2[1]));

                return _expenseDal.GetAll(p => p.DateOperation >= dateTimeStart && p.DateOperation <= dateTimeFinaly);
            }
            catch (Exception)
            {
                return null;
            }

        }


        /*
        public List<Expense> GetPersonsByCetegory(int categoryID)
        {
            return _expenseDal.GetAll(p => p.ExpenseId == categoryID);
        }

        public List<Expense> GetExpensesByProductName(string ExpenselName)
        {
            return _expenseDal.GetAll(p => p.ExpenselName.ToLower().Contains(ExpenselName.ToLower()));
        }
        */

        #endregion


    }
}
