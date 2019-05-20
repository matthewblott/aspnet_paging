using aspnet_paging.models;
using aspnet_paging.services;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_paging.controllers
{
  public class ProductsController : Controller
  {
    private readonly IProductService _productService;
    
    public ProductsController(IProductService productService)
    {
      _productService = productService;
    }
    
    public IActionResult Index(int p = 1)
    {
      var pagedResult = _productService.Find(p);
      
      var model = new ProductListViewModel
      {
        Products = pagedResult
      };
      
      return View(model);
            
    }

  }
  
}