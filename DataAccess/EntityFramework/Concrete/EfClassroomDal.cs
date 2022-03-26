using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Concrete
{
    public class EfClassroomDal : EfEntityRepositoryBase<Classroom, Context>, IClassroomDal
    {
       
    }
}
