using Microsoft.AspNetCore.Mvc;
using PekerStore.Data.Abstract;

namespace PekerStore.Web.Controllers;

public class HomeController : Controller
{   

    private IStoreRepository _storeRepository;

    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }
    
    public ActionResult Index()
    {
        return View();
    }
}