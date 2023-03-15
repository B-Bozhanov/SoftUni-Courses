namespace BookStoreMvcApp
{
    using System.Text;

    using BookStoreMvcApp.Controllers;

    using BookStory.Services;
    using BookStory.Services.TextDto;

    public class ConsoleUI
    {
        private readonly IAccountService accountService;
        private readonly IBookService bookService;
        private readonly ITextService textService;

        public ConsoleUI(IAccountService accountService, IBookService bookService, ITextService textService)
        {
            this.accountService = accountService;
            this.bookService = bookService;
            this.textService = textService;
        }

        public void Start()
        {
            var homePageJson = new HomeController().Index();

            var jsonTextModels = this.textService.Deserialize(homePageJson);

            while (true)
            {
                this.PrintCollection(jsonTextModels);

                var input = int.Parse(Console.ReadLine()!);

                Console.Clear();

                if (input == 0)
                {
                    Console.WriteLine("Good bye !");
                    Thread.Sleep(2000);
                    break;
                }

                this.UserInputHandeler(input);
            }
        }

        private void UserInputHandeler(int input)
        {
            switch (input)
            {
                case 2: this.Login(); break;
                case 3: this.AccountCreate(); break;
            }
        }

        private void Login()
        {
            var loginPageJson = new HomeController().Login();

            var exportJsonModel = this.textService.Deserialize(loginPageJson);

            this.PrintCollection(exportJsonModel);

            // Console.WriteLine(userLoginresponse.Result[0]);
            var username = Console.ReadLine();

            //  Console.WriteLine(userLoginresponse.Result[1]);
            var password = Console.ReadLine();

            var encryptedPassword = this.accountService.EncryptPassword(password!);

            try
            {
                var account = this.accountService.Login(username!, encryptedPassword);

                while (true)
                {
                    Console.WriteLine("Press 1 to search book");
                    var userBook = Console.ReadLine();

                    var book = this.bookService.GetByTitle(userBook!);
                }

                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Thread.Sleep(5000);
                Console.Clear();
            }
        }

        private void AccountCreate()
        {
            try
            {
                Console.WriteLine("Enter your first name:");
                var firstname = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter your last name:");
                var lastname = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter your age:");
                var years = int.Parse(Console.ReadLine()!);
                Console.Clear();

                Console.WriteLine("Enter your username:");
                var username = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Enter your email address:");
                var email = Console.ReadLine();
                Console.Clear();

                this.accountService.PasswordValidator(password!);

                var encyptedPassword = this.accountService.EncryptPassword(password!);

                this.accountService.CreateAccount(firstname!, lastname!, years, username!, encyptedPassword, email!);
                Console.WriteLine("Account is created successful !");

                Thread.Sleep(1000);
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Thread.Sleep(5000);
                Console.Clear();
            }
        }

        private void PrintCollection(IEnumerable<ExportTexModel> collection)
        {
            foreach (var item in collection)
            {
                if (item.Id == null)
                {
                    Console.WriteLine($"{item.Action} {item.Message}");
                }
                else
                {
                    Console.WriteLine($"{item.Action} {item.Id} {item.Message}");
                }
            }
        }
    }
}
