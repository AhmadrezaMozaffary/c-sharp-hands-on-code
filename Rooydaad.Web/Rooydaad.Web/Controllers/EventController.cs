using Microsoft.AspNetCore.Mvc;
using Rooydaad.Web.Data;
using System.Collections.Generic;

namespace Rooydaad.Web.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            List<Event> events = Database.GetAvailableEvents();
            return View(events);
        }
    }
}
