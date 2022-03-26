using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClassroomService _classroomService;
        private readonly IStudentService _studentService;
        private readonly ILessonService _lessonService;
        private readonly ITeacherService _teacherService;
        public HomeController(ILogger<HomeController> logger, IClassroomService classroomService = null, IStudentService studentService = null, ILessonService lessonService = null, ITeacherService teacherService = null)
        {
            _logger = logger;
            _classroomService = classroomService;
            _studentService = studentService;
            _lessonService = lessonService;
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Classroom()
        {
            var classrooms = _classroomService.GetAll();
            return View(classrooms);
        }       

        public IActionResult Students()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
        public IActionResult Lessons()
        {
            var lessons = _lessonService.GetLessonDetails();
            return View(lessons);
        }
        public IActionResult Teachers()
        {
            var teachers = _teacherService.GetAll();
            return View(teachers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
