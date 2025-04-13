using Microsoft.AspNetCore.Mvc;
using CodeHollow.FeedReader;
using System.Linq;
using System.Threading.Tasks;

namespace Persona01.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var feed = await FeedReader.ReadAsync("https://www.filmweb.pl/rss/news");
            ViewBag.NewsItems = feed.Items.Take(5).ToList();
            return View();
        }
    }
}
