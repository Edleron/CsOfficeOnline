using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Concrete;

namespace OfficeOnline.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetPersonId(string personName);       
        bool GetAuthentication(string newUserName, string newPassword);
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);


        /*               
       List<Person> GetPersonsByCategory(int categoryID);
       List<Person> GetPersonsByProductName(string personName);
       */
    }
}
