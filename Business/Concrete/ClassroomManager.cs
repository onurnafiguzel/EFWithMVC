using Business.Abstract;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ClassroomManager : IClassroomService
    {
        IClassroomDal _clasroomDal;

        public ClassroomManager(IClassroomDal clasroomDal)
        {
            _clasroomDal = clasroomDal;
        }

        public void Add(Classroom classroom)
        {
            _clasroomDal.Add(classroom);
        }

        public void Delete(Classroom classroom)
        {
            _clasroomDal.Delete(classroom);
        }

        public List<Classroom> GetAll()
        {
            return _clasroomDal.GetAll();
        }

        public void Update(Classroom classroom)
        {
            _clasroomDal.Update(classroom);
        }
    }
}
