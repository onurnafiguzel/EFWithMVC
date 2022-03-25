using Entities.Concrete;
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
        public void Update(int id);
        public void Delete(int id);
        public List<Lesson> GetAll();
    }
}
