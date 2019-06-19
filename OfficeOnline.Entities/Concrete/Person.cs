using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Abstract;

namespace OfficeOnline.Entities.Concrete
{
    public class Person : IEntity
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
