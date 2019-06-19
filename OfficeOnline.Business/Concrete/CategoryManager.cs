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
    public class CategoryManager : ICategoryService
    {
        #region Property
        private ICategoryDal _categoryDal;
        #endregion

        #region Constructors
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }        
        #endregion

        #region Operation
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }
        #endregion
    }
}
