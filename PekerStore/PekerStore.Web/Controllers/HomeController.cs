using Microsoft.AspNetCore.Mvc;
using PekerStore.Data.Abstract;
using PekerStore.Web.ViewModels;

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
        var products = _storeRepository.Products.Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Category = p.Category,
            Description = p.Description,
        }).ToList();

        return View(new ProductListViewModel
        {
            Products = products
        });
    }
}