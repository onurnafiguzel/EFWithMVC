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
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public void Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
        }
    }
}
