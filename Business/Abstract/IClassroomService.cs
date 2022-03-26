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
        public void Update(Classroom classroom);
        public void Delete(Classroom classroom);
        public List<Classroom> GetAll();
    }
}
