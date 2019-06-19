using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOnline.Entities.Concrete;
using OfficeOnline.DataAccess.Abstract;

namespace OfficeOnline.DataAccess.Concrete.EntityFramework
{
    public class EfExpenseDal : EfEntityRepositoyBase<Expense, OfficeOnlineContext>, IExpenseDal
    {

    }
}
