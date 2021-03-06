using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILessonService
    {
        public void Add(Lesson lesson);
        public void Update(Lesson lesson);
        public void Delete(Lesson lesson);
        public List<Lesson> GetAll();
        public List<LessonDetailDto> GetLessonDetails();
    }
}
