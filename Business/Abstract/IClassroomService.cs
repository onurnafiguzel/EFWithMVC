using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IClassroomService
    {
        public void Add(Classroom classroom);
        public void Update(int id);
        public void Delete(int id);
        public List<Classroom> GetAll();
    }
}
