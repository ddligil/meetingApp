using meetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingApp.Controllers
{

     public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "iyi günler" : "iyi akşamlar";
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();


            var meetingInfo = new MeetingInfo()
            {
                Id=1,
                Location="Ankara",
                Date= new DateTime(2026,01,20,20,0,0),
                NumberOfPeople =UserCount
            };


                return View(meetingInfo);
        } 
    }
}