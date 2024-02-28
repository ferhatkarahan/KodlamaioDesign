using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Instructor : IEntity
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }  = string.Empty;
        public string FullName => $"{FirstName} {LastName.ToUpper()}";   //String.Format("{0} {1}", FirstName, LastName.ToUpper());
        public string Email { get; set; }  =string.Empty;

        

    }
}
