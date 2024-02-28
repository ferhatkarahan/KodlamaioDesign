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
    public class CourseManager : ICourseServices
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            _courseDal.DeleteCourse(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public List<Course> GetCourseByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourseByInstructor(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            _courseDal.UpdateCourse(course);
        }
    }
}
