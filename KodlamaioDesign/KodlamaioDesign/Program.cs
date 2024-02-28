using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace KodlamaioDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Category> categories = new List<Category>()
            //{
            //    new Category { CategoryId = 1,CategoryName="Programlama"},
            //    new Category { CategoryId = 2,CategoryName="Tasarım"},
            //    new Category { CategoryId = 3,CategoryName="Yazılım"}
            //};
            
            ICategoryServices categoryManager=new CategoryManager(new CategoryDal());

            //List<Category> categories = categoryManager.GetAll();
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}


            //Select  with linq
            var result = categoryManager.GetAll().Select(p => p.CategoryName).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            //Category instance
            Category category = new Category { CategoryId = 4, CategoryName = "Meslek Bilgilendirme" };
            //Add
            categoryManager.AddCategory(category);
                
            //Delete
            categoryManager.DeleteCategory(category);
            //update
            categoryManager.UpdateCategory(category);
            


            CourseManager courseManager = new CourseManager(new CourseDal());



            InstructorManager instructorManager=new InstructorManager(new InstructorDal());




           // Console.WriteLine("Hello, World!");
        }
    }
}
