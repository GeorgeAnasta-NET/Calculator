using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(string firstNumber, string secondNumber, string Cal)
        {
            double firstNum = string.IsNullOrEmpty(firstNumber) ? 0 : Convert.ToInt32(firstNumber);
            double result = 0;
            double secondNum = 0;
            
            if (Cal != "sqrt" || Cal != ("x^2"))
                secondNum = string.IsNullOrEmpty(secondNumber) ? 0 : Convert.ToInt32(secondNumber);
            
            switch (Cal)
            {
                case "+":
                    result = Calc.Calculator.Addition(firstNum, secondNum);
                    break;
                case "-":
                    result = Calc.Calculator.Substaction(firstNum, secondNum);
                    break;
                case "*":
                    result = Calc.Calculator.Multiplication(firstNum, secondNum);
                    break;
                case "/":
                    result = Calc.Calculator.Division(firstNum, secondNum);
                    break;
                case ("sqrt"):
                    result = Math.Sqrt(firstNum);
                    break;
                case ("x^2"):
                    result = Calc.Calculator.Multiplication(firstNum, firstNum);
                    break;
            }
            ViewBag.Result = result;
            return View();
        }
    }
}