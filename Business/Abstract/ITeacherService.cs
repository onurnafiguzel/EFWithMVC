using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        public void Add(Teacher teacher);
        public void Update(Teacher teacher);
        public void Delete(Teacher teacher);
        public List<Teacher> GetAll();
    }
}
