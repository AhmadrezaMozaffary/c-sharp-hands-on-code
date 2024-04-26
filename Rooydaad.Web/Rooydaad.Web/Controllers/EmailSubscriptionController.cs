using Microsoft.AspNetCore.Mvc;

namespace Rooydaad.Web.Controllers
{
    public class EmailSubscriptionController : Controller
    {
        [HttpPost]
        public IActionResult Index(Data.EmailSubscription  subscription)
        {
            return Redirect($"/Home/Index/?message=Email ({subscription.EmailAddress}) subscribed.");
        }
    }
}
