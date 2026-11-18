namespace ContosoUniversity.Features.Percentage
{
    using System.Web.Mvc;

    /// <summary>
    /// The percentage page, reached as /Percentage by the default route.
    /// </summary>
    public class UiController : Controller
    {
        /// <summary>Shows the percentage form with no result.</summary>
        /// <returns>The percentage view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>Shows what percentage the part is of the whole.</summary>
        /// <param name="part">The number taken as a part.</param>
        /// <param name="whole">The number taken as the whole.</param>
        /// <returns>The percentage view, carrying both numbers and the result.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(decimal part, decimal whole)
        {
            ViewBag.Part = part;
            ViewBag.Whole = whole;
            ViewBag.Result = Percentage.Of(part, whole);

            return View();
        }
    }
}
