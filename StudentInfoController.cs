using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentInfoController : Controller
    {
        private readonly IConfiguration _configuration;

        public StudentInfoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.StudentName = _configuration["StudentSettings:Name"] ?? "Not Configured";
            ViewBag.StudentId = _configuration["StudentSettings:StudentId"] ?? "Not Configured";
            ViewBag.Unit = _configuration["StudentSettings:Unit"] ?? "Not Configured";
            ViewBag.ServerTime = DateTime.Now.ToString("dd MMM yyyy, hh:mm:ss tt");
            return View();
        }
    }
}