using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public void AddCategory(Category category)
        {
            Console.WriteLine("Category ekleme işlemi gerçekleşti. ");
        }

        public void DeleteCategory(Category category)
        {
            Console.WriteLine("Category silme işlemi gerçekleşti. ");
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>()
            {
                new Category { CategoryId = 1,CategoryName="Programlama"},
                new Category { CategoryId = 2,CategoryName="Tasarım"},
                new Category { CategoryId = 3,CategoryName="Yazılım"}
            };
            return categories.ToList();
        }

        public Category GetCategory(int id)
        {
            Console.WriteLine("Category getirme işlemi gerçekleşti. ");
            return GetCategory(id);
        }

        public void UpdateCategory(Category category)
        {
            Console.WriteLine("Category güncelleme işlemi gerçekleşti. ");
        }
    }
}
