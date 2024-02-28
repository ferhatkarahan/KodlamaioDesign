using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        Instructor GetInstructor(int id);
        void AddInstructor(Instructor instructor);
        void DeleteInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
    }
}
