using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryServices
    {
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        List<Category> GetAll();
        void UpdateCategory(Category category);
    }
}
