
using ATMapp.Domain.Entities;
using ATMapp.UI;

AppScreen screen = new AppScreen();
Utility utility = new Utility();
Validator validator = new Validator();

screen.WelcomeMessage();
long cardNumber = validator.Convert<long>("your card number");
Console.WriteLine($"Your card number is {cardNumber}");

utility.PressEnterToContinue();