namespace BookStoreMvcApp.Controllers
{
    using BookStory.MvcFramework;

    public class HomeController : Controller
    {
        public string Index()
        {
            return this.View();
        }

        public string Login()
        {
            return this.View();
        }
    }
}
