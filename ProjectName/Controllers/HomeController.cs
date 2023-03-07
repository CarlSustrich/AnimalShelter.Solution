using Microsoft.AspNetCore.Mvc;


namespace Name
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() 
    {
      return View();
    }

  }
}
