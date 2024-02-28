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
    public class InstructorManager : IInstructorServices
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void AddInstructor(Instructor instructor)
        {
            _instructorDal.AddInstructor(instructor);
        }

        public void DeleteInstructor(Instructor instructor)
        {
            _instructorDal.DeleteInstructor(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll(); 
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _instructorDal.UpdateInstructor(instructor);
        }
    }
}
