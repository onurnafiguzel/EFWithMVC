using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        public void Add(Student student);
        public void Update(int id);
        public void Delete(int id);
        public List<Student> GetAll();
    }
}
