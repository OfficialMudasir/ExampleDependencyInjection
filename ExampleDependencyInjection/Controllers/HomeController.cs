using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExampleDependencyInjection.Models;
using Microsoft.Extensions.Logging;

namespace ExampleDependencyInjection.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ItransientService _transientService1;
        private readonly ItransientService _transientService2;
        private readonly ItransientService _transientService3;

        private readonly IScoppedService _scoppedService1;
        private readonly IScoppedService _scoppedService2;
        private readonly IScoppedService _scoppedService3;

        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        private readonly ISingletonService _singletonService3;


        public HomeController(ILogger<HomeController> logger,
            ItransientService transientService1,
            ItransientService transientService2,
            ItransientService transientService3,

            IScoppedService scopedService1,
            IScoppedService scopedService2,
            IScoppedService scopedService3,

            ISingletonService singletonService1,
            ISingletonService singletonService2,
            ISingletonService singletonService3)
            
        {
            _logger = logger;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _transientService3 = transientService3;

            _scoppedService1 = scopedService1;
            _scoppedService2 = scopedService2;
            _scoppedService3 = scopedService3;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _singletonService3 = singletonService3;


        }


        /*public int StudentId;
        public string Name;
        public DateTime? DateOfBirth;
        public byte Photo;
        public decimal Height;
        public decimal Weight;
        private List<Student> listStudents = new List<Student>();
        public HomeController()
        {
            listStudents = new List<Student>()
            {
                new Student {StudentId = 101, Name = "Wani", Height = 5, Weight=70},
                new Student {StudentId = 102, Name = "Mudasir", Height = 7, Weight=70},

            };


        }*/



        public IActionResult Index()
        {

            ViewBag.transient1 = _transientService1.GetOperationID().ToString();
            ViewBag.transient2 = _transientService2.GetOperationID().ToString();
            ViewBag.transient3 = _transientService3.GetOperationID().ToString();

            ViewBag.scopped1 = _scoppedService1.GetOperationID().ToString();
            ViewBag.scopped2 = _scoppedService2.GetOperationID().ToString();
            ViewBag.scopped3 = _scoppedService2.GetOperationID().ToString();

            ViewBag.singleton1 = _singletonService1.GetOperationID().ToString();
            ViewBag.singleton2 = _singletonService2.GetOperationID().ToString();
            ViewBag.singleton3 = _singletonService3.GetOperationID().ToString();



            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
