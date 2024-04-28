using SecondCourseProject.Models;
using Microsoft.AspNetCore.Mvc;
using FithCourseProject.Services;

namespace SecondCourseProject.Controllers
{
    public class FriendController : Controller
    {
        IFriendsRepositoryService _service;
        public FriendController(IFriendsRepositoryService service)
        {
            _service = service;
        }

        public IActionResult List()
        {
            return View(_service.Read());
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
                _service.Create(friend);
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
            ViewBag.CurrentFriend = _service.Read().Find(f => f.Id == id);
            return View();
        }

        [Route("/Friend/Delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Redirect("~/Friend/List");
        }
    }
}
