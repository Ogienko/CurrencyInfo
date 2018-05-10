using CurrencyInfo.Services;
using System.Web.Mvc;

namespace CurrencyInfo.Controllers
{
    public class CurrencyController : Controller
    {
        public ActionResult Index()
        {
            var stock = CurrencyService.GetStock();
            return View(stock);
        }

        public ActionResult GetCurrencies()
        {
            var stock = CurrencyService.GetStock();
            return PartialView("_CurrenciesPartial", stock.Currencies);
        }
    }
}