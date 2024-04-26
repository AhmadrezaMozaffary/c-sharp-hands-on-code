using SecondCourseProject.Models;
using Microsoft.AspNetCore.Mvc;
using SecondCourseProject.Data;

namespace SecondCourseProject.Controllers
{
    public class FriendController : Controller
    {

        public IActionResult List()
        {
            return View(DataBase.GetFriendsList());
        }

        [HttpGet]
        public IActionResult AddNew()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddNew(FriendModel friend)
        {
            if (ModelState.IsValid)
            {
                DataBase.AddFriend(friend);
                return Redirect("~/Friend/List");
            }
            else
            {
                ViewBag.Err = "Form is not valid";
                return View();

            }
        }


        [Route("Friend/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.CurrentFriend = DataBase.GetFriendsList().Find(f => f.Id == id);
            return View();
        }
    }
}
