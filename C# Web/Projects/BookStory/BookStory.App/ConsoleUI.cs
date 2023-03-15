namespace BookStory.UI.ConsoleUI
{
    using System.Reflection;

    using BookStory.Controlers;
    using BookStory.Data.Data;
    using BookStory.Services;


    public class ConsoleUI
    {
        private readonly IAccountService accountService;
        private readonly IBookService bookService;

        public ConsoleUI(IAccountService accountService, IBookService bookService)
        {
            this.accountService = accountService;
            this.bookService = bookService;
        }

        public async Task Start()
        {
            while (true)
            {
                Console.WriteLine($"Press 1 to Login");
                Console.WriteLine($"Press 2 to create new account");
                Console.WriteLine("Press 0 to exit !");
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
                case 1: this.Login(); break;
                case 2: this.AccountCreate(); break;
            }
        }

        private async Task Login()
        {

            var controler = new HomeControler();

            var userLoginresponse = controler.Login();

            Console.WriteLine(userLoginresponse.Result[0]);
            var username = Console.ReadLine();

            Console.WriteLine(userLoginresponse.Result[1]);
            var password = Console.ReadLine();

            var encryptedPassword = this.accountService.EncryptPassword(password!);

            try
            {
                var account = this.accountService.Login(username!, encryptedPassword);

                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Press 1 to search book");
                    var userBook = Console.ReadLine();

                    var book = this.bookService.GetByTitle(userBook!);
                }

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
    }
}
