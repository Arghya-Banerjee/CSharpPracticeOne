using Core;
using Microsoft.AspNetCore.Mvc;
using PracticeOne.Models;
using System.Diagnostics;

namespace PracticeOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowData()
        {
            List<UserModel> users = new List<UserModel>();
            UserModel obj = new UserModel();
            obj.firstname = "Arghya";
            obj.surname = "Banerjee";
            obj.phonenumber = "9433458371";
            obj.opmode = 0;
            users = DBOperations<UserModel>.GetAllOrByRange(obj, Constant.usp_GetAllData);
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
