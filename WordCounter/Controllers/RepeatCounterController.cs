using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("/counter")]
    public ActionResult Index()
    {

      List<RepeatCounter> allRepeatCounters = RepeatCounter.CounterList;
      return View(allRepeatCounters);
    }

    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counter")]
    public ActionResult Create(string word, string phrase)
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(word, phrase);
      return RedirectToAction("Index");
    }

    [HttpGet("/counter/{id}")]
    public ActionResult Show(int id)
    {
      RepeatCounter repeatCounter = RepeatCounter.Find(id);
      return View(repeatCounter);
    }
    // [HttpPost("/cars/{id}/delete")]
    // public ActionResult Destroy(int id)
    // {
    //   Car.RemoveCar(id);
    //   return RedirectToAction("Index");
    // }
    //

  }
}
