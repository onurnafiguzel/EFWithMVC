using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Concrete
{
    public class EfLessonDal : EfEntityRepositoryBase<Lesson, Context>, ILessonDal
    {
        public List<LessonDetailDto> GetLessonDetails()
        {
            using (Context context = new Context())
            {
                var result = from l in context.Lessons
                             join t in context.Teachers
                             on l.TeacherId equals t.Id
                             join c in context.Classrooms
                             on l.ClassroomId equals c.Id
                             select new LessonDetailDto
                             {
                                 Id = l.Id,
                                 Name = l.Name,
                                 ClassroomName = c.Name,
                                 TeacherName = t.FirstName
                             };
                return result.ToList();
            }
        }
    }
}
