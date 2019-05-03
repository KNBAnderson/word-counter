using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterControllerTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }

    [TestMethod]
    public void Index_HasCorrectModelType_CounterList()
    {
      ViewResult indexView = new RepeatCounterController().Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        RepeatCounterController controller = new RepeatCounterController();
        IActionResult view = controller.Create("Barbie", "Barbie dream car");
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        //Arrange
        RepeatCounterController controller = new RepeatCounterController();
        RedirectToActionResult actionResult = controller.Create("Barbie", "Barbie dream car") as RedirectToActionResult;
        string result = actionResult.ActionName;
        Assert.AreEqual(result, "Index");
    }
  }
}
