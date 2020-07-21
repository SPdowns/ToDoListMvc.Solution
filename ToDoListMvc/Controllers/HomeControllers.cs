using Microsoft.AspNetCore.Mvc;
using ToDoListMvc.Models;
using System.Collections.Generic;

namespace ToDoListMvc.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}