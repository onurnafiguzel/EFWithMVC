using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Classroom
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        //Navigation Property
        public List<Lesson> Lessons { get; set; }
    }
}
