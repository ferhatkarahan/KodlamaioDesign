using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetCourse(int id);
        void AddCourse(Course course);
        void DeleteCourse(Course course);
        void UpdateCourse(Course course);
    }
}
