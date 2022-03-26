using Business.Abstract;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public void Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);
        }

        public void Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
        }

        public List<Lesson> GetAll()
        {
            return _lessonDal.GetAll();
        }

        public List<LessonDetailDto> GetLessonDetails()
        {
            return _lessonDal.GetLessonDetails();
        }

        public void Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
        }
    }
}
