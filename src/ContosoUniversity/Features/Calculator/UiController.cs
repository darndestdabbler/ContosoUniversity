namespace ContosoUniversity.Features.Calculator
{
    using System.Web.Mvc;

    /// <summary>
    /// The calculator page, reached as /Calculator by the default route.
    /// </summary>
    public class UiController : Controller
    {
        /// <summary>Shows the calculator form with no result.</summary>
        /// <returns>The calculator view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>Shows the sum and the difference of the two numbers submitted.</summary>
        /// <param name="left">The first number.</param>
        /// <param name="right">The second number.</param>
        /// <returns>The calculator view, carrying both numbers and both results.</returns>
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
