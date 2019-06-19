using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.DataAccess.Abstract;
using OfficeOnline.Entities.Concrete;
using OfficeOnline.Business.Abstract;
using OfficeOnline.Business.Utilities;
using OfficeOnline.Business.ValidationRules.FluentValidation;


namespace OfficeOnline.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        #region Property
        private IPersonDal _personDal;
        #endregion

        #region Constructors
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        #endregion

        #region Operation
        public void Add(Person person)
        {
            ValidationTool.Validate(new PersonValidator(), person);
            _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            try
            {
                _personDal.Delete(person);
            }
            catch
            {
                throw new Exception("Silme İşlemi Gerçekleştirilemedi");
            }
        }

        public void Update(Person person)
        {
            ValidationTool.Validate(new PersonValidator(), person);
            _personDal.Update(person);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }     

        public bool GetAuthentication(string newUserName, string newPassword)
        {
            var u  = _personDal.Get(p => p.UserName == newUserName && p.UserPassword == newPassword);
            if (u != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Person GetPersonId(string personName)
        {
            return _personDal.Get(p => p.UserName == personName);
        }

        /*
       public List<Person> GetPersonsByCategory(int categoryID)
       {
           //Bura Yoruma Alınacak
           return _personDal.GetAll(p => p.PersonId == categoryID);
       }


      

       public List<Person> GetPersonsByProductName(string personName)
       {
           return _personDal.GetAll(p => p.PersonName.ToLower().Contains(personName.ToLower()));
       }
       */






        #endregion
    }
}
