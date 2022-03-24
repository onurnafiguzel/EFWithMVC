using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SchoolId { get; set; }

        //Navigation Property
        public ICollection<StudentLesson> Lessons { get; set; } = new HashSet<StudentLesson>();
    }
}
