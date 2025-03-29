using bmicalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace bmicalculator.Controllers
{
    public class BMICalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMICalculator model)
        {
            if (model.Weight > 0 && model.Height > 0)
            {
                model.BMI = model.Weight / (model.Height * model.Height);

                if (model.BMI < 18.5)
                {
                    model.Category = "Underweight";
                }
                else if (model.BMI >= 18.5 && model.BMI < 24.9)
                {
                    model.Category = "Normal weight";
                }
                else if (model.BMI >= 25 && model.BMI < 29.9)
                {
                    model.Category = "Overweight";
                }
                else
                {
                    model.Category = "Obese";
                }
            }

            return View(model);
        }
    }
}
