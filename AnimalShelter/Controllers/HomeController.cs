using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
namespace AnimalShelter.Controllers;


public class HomeController : Controller
{

  [Route("/")]
  public ActionResult Index() 
  {
    return View();
  }

}
