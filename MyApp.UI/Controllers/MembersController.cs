using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.UI.Controllers
{
    public class MembersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddMember()
        {
            return View();
        }

        public ActionResult EditMember()
        {
            return View();
        }

        public ActionResult ViewDetails()
        {
            return View();
        }

    }
}
