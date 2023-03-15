namespace BookStory.MvcFramework
{
    using System.Runtime.CompilerServices;

    public abstract class Controller
    {
        public string View([CallerMemberName] string methodName = null!)
        {
            var views = "Views/";

            var controllerName = this.GetType().Name.Replace("Controller", string.Empty) + '/';

            var fileExtencion = ".json";

            var result = File.ReadAllText(views + controllerName + methodName + fileExtencion);

            return result;
        }
    }
}
