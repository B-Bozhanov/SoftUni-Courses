//TODO: Validation on everything!

using BookStoreMvcApp;

using BookStory.Data.Data;
using BookStory.Services;


IRepository repository = new Repository();
repository.Migration();
IBookService bookService = new BookService(repository);
IAccountService accountService = new AccountService(repository);
ITextService textService = new TextService();

var consoleUI = new ConsoleUI(accountService, bookService, textService);

consoleUI.Start();

/*
/CreateAccount => View("CreateAccount")
First name = ...
Last name = ...
Years = ...
Username = ...
Password = ...
Email = ...
*/


//var account = accountService.CreateAccount("Bozhan", "Bozhanov", 34, "DareDeviL", "2010Borkata", "bbozhanov@sot.bg");