using System;
namespace ATMapp.UI
{
	public class AppScreen
	{
		public void WelcomeMessage()
		{
			var utility1 = new Utility();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to VerityBank\n");
            utility1.PressEnterToContinue();

        }
	}
}

