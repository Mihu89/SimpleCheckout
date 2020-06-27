using SimpleCheckout.Interfaces;
using System.Web.Mvc;

namespace SimpleCheckout.Controllers
{
    public class HomeController : Controller
    {
        private IMobileRepo _mobileRepo;

        public HomeController(IMobileRepo mobileRepo)
        {
            _mobileRepo = mobileRepo;
        }

        public ActionResult Index()
        {
            var mobiles = _mobileRepo.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}