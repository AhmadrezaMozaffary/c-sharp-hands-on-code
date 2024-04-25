using FirstCourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCourseProject.Controllers
{
    public class FriendController : Controller
    {
        private List<FriendModel> FriendsList = new();

        public FriendController()
        {
            FriendsList.Add(new FriendModel(1, "Abolfazl Norouzi", "09192224455", ""));
            FriendsList.Add(new FriendModel(2, "Amirreza Mozaffary", "09194444455", ""));
            FriendsList.Add(new FriendModel(3, "Ali Motamedi", "09194534455", ""));
            FriendsList.Add(new FriendModel(4, "Farid Mojaddam", "09192344455", ""));
            FriendsList.Add(new FriendModel(5, "Amin Afrasiabi", "09191239455", ""));
        }

        public IActionResult List()
        {
            ViewBag.Friends = FriendsList;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
