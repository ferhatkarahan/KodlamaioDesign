using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorServices
    {
        void AddInstructor(Instructor instructor);
        void DeleteInstructor(Instructor instructor);
        List<Instructor> GetAll();
        void UpdateInstructor(Instructor instructor);
    }
}
