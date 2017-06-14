using System.Web.Mvc;

namespace EMS.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //var geralChurch = ContainerFactory.Get<IChurchAppService>().GetAll();
            //var churchList = Mapper.Map<IList<Church>, IList<ChurchViewModel>>();

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}