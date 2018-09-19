using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefaultProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DefaultProject.Controllers
{
    public class StudentController : Controller
    {
        public ProjectContext  _ORM =null;
            
            public StudentController(ProjectContext ORM)

        {
            _ORM = ORM;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}