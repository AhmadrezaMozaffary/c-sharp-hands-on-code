using FirstCourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCourseProject.Controllers
{
    public class FriendController : Controller
    {
        private List<FriendModel> FriendsList = new();

        public FriendController()
        {
            InitFriendsList();
        }

        private void InitFriendsList()
        {
            FriendsList.Add(new FriendModel(1, "Abolfazl Norouzi", "0919-2224455", "/img/1.jpg"));
            FriendsList.Add(new FriendModel(2, "Amirreza MozaffaryDehno", "0919-4444455", "/img/2.jpg"));
            FriendsList.Add(new FriendModel(3, "Ali Motamedi", "0919-4534455", "/img/3.jpg"));
            FriendsList.Add(new FriendModel(4, "Farid Mojaddam", "0919-2344455", "/img/4.jpg"));
            FriendsList.Add(new FriendModel(5, "Amin Afrasiabi", "0919-1239455", "/img/5.jpg"));

        }

        public IActionResult List()
        {
            ViewBag.Friends = FriendsList;
            return View();
        }

        [Route("Friend/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.CurrentFriend = FriendsList.Find(f => f.Id == id);
            return View();
        }
    }
}
