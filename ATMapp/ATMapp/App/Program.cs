
using ATMapp.Domain.Entities;
using ATMapp.UI;

AppScreen screen = new AppScreen();
Utility utility = new Utility();
Validator validator = new Validator();
UserAccount user = new UserAccount();

screen.WelcomeMessage();

user.CheckUserCardNumberAndPassword();

utility.PressEnterToContinue();