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
        public void Update(Student student);
        public void Delete(Student student);
        public List<Student> GetAll();
    }
}
