using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{

    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult SquareRoot()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SquareRoot(string FirstNumber, string SecondNumber) {
          
          double NumberOne = double.Parse(FirstNumber);
          double NumberTwo = (double.Parse(SecondNumber));

          double SqrtOne = Math.Round(Math.Sqrt(NumberOne),3);
          double SqrtTwo = Math.Round(Math.Sqrt(NumberTwo),3);
          
          ViewBag.First = double.Parse(FirstNumber);
          ViewBag.Second = double.Parse(SecondNumber);
          ViewBag.NumOne = NumberOne;
          ViewBag.NumTwo = NumberTwo;
          ViewBag.SqrtOne = SqrtOne;
          ViewBag.SqrtTwo = SqrtTwo;
          return View();
            
        } 
    }

}