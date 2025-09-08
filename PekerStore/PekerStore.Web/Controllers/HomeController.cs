using Microsoft.AspNetCore.Mvc;

namespace PekerStore.Web.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}