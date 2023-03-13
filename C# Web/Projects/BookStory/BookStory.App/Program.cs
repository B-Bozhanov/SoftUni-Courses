//TODO: Validation on everything!

using BookStory.App;
using BookStory.Data.Data;
using BookStory.Services;

IRepository repository = new Repository();
repository.Migration();
IBookService bookService = new BookService(repository);
IAccountService accountService = new AccountService(repository);

var ui = new ConsoleUI(accountService, bookService);

ui.Start();
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