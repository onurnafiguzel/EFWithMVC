﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Student> Students { get; set; }

        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}