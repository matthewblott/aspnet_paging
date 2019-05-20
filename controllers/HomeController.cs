using Microsoft.AspNetCore.Mvc;

namespace aspnet_paging.controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

  }
    
}
