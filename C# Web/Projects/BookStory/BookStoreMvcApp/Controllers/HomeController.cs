using System.IO;

using BookStory.MvcFramework;

namespace BookStoreMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return this.View("Views/Index.txt");
        }
    }
}
