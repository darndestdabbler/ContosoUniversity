namespace ContosoUniversity.Features.Calculator
{
    using System.Web.Mvc;

    public class UiController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(decimal left, decimal right)
        {
            ViewBag.Left = left;
            ViewBag.Right = right;
            ViewBag.Sum = Calculator.Add(left, right);
            ViewBag.Difference = Calculator.Subtract(left, right);

            return View();
        }
    }
}
