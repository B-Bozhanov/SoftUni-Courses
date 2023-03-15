namespace BookStory.MvcFramework
{
    public abstract class Controller
    {
        public string View(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
