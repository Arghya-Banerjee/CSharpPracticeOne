using Core;
using Microsoft.AspNetCore.Mvc;
using PracticeOne.Models;

namespace PracticeOne.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonView()
        {
            return View();
        }

        public IActionResult PersonGetDataPage() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonGetData(PersonModel model)
        {
            model.Opmode = 1;
            int res = DBOperations<PersonModel>.DMLOperation(model, Constant.usp_PersonValidation);
            return RedirectToAction("PersonGetDataPage");
        }

        public IActionResult PersonShowData()
        {   
            List<PersonModel> users = new List<PersonModel>();
            PersonModel obj = new PersonModel();
            obj.Opmode = 0;
            users = DBOperations<PersonModel>.GetAllOrByRange(obj, Constant.usp_PersonValidation);
            return View(users);
        }
    }
}
