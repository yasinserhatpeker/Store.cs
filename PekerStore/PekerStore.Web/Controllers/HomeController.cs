using Microsoft.AspNetCore.Mvc;
using PekerStore.Data.Abstract;
using PekerStore.Web.ViewModels;

namespace PekerStore.Web.Controllers;

public class HomeController : Controller
{
    public int pageSize = 3;
    private IStoreRepository _storeRepository;

    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }

    public ActionResult Index(int page=1)
    {
        var products = _storeRepository.
        Products.
        Skip((page -1 ) * pageSize).
        Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Category = p.Category,
            Price = p.Price,
            Description = p.Description,
        }).Take(pageSize);

        return View(new ProductListViewModel
        {
            Products = products
        });
    }
}