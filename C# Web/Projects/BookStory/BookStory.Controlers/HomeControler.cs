namespace BookStory.Controlers
{
    using BookStory.
    public class HomeControler
    {
        private readonly string[] userInputView;
        private readonly string[] indexMessage;

        public HomeControler()
        {
            this.userInputView = new string[2]
            {
                "Enter your username!",
                "Enter your password"
            };


        }

        public string[] Index()
        {
            var indexView = new Index
            {

            }
            return new string
            {

            }
        }

        public async Task<string[]> Login()
        {
           return  this.userInputView;
        }
    }
}