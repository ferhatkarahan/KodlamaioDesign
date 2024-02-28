using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void AddCategory(Category category)
        {
            _categoryDal.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.DeleteCategory(category);
        }

        public List<Category> GetAll()
        {
            
            return _categoryDal.GetAll();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.UpdateCategory(category);
        }
    }
}
