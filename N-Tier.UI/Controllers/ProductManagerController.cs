using Microsoft.AspNetCore.Mvc;
using N_tier.Core.Models;
using N_tier.Core.ViewModels;
using N_tier.DataAccess.InMemory;

namespace N_tier.WebUI.Controllers
{
    public class ProductManagerController : Controller
    {
        ProductRepository _context;
        ProductCategoryRepository _contextCategory;
        public ProductManagerController(ProductRepository context, ProductCategoryRepository contextCategory)
        {
            _context = context;
            _contextCategory = contextCategory;
        }


        public IActionResult Index()
        {

            // get Models from _context and pass them in view
            return View();
        }

        public IActionResult Create()
        {
            ProductManagerViewModel viewModel = new ProductManagerViewModel();
            viewModel.Product = new Product();
            //viewModel.ProductCategories // = _contextCategory
            return View(viewModel);
        }


    }
}