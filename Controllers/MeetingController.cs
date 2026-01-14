
using meetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingApp.Controllers
{
    
    public class MeetingController : Controller
    {

       

        [HttpGet] // aksi yazılmadığı sürece action metotu get olarak defoult tanımlanmıstır
        public IActionResult Apply()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (!ModelState.IsValid)
            {
                return View();    //is valid true ise null değer gönderilmemiştir ama null değer girildiyse formu tekrar göster
            }

            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks",model);

        }
        [HttpGet]
        public IActionResult List()
        {

            return View(Repository.Users);

        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            return View(Repository.GetUserById(id));

        }



        }
    }
