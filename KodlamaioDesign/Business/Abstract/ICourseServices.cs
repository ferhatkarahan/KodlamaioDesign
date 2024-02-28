using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseServices
    {
        void AddCourse(Course course);
        void DeleteCourse(Course course);
        List<Course> GetAll();
        void UpdateCourse(Course course);
        List<Course> GetCourseByCategory(int categoryId);
        List<Course> GetCourseByInstructor(int instructorId);
    }
}
