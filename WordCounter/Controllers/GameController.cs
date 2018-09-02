using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

 namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create()
    {
      
      RepeatCounter newRepeatCounter = new RepeatCounter ();
      RepeatCounter.
    }

  }
}