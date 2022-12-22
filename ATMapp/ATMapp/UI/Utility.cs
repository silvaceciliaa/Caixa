using System;
namespace ATMapp.UI
{
	public class Utility
	{
		public void PrintMessage(string msg, bool success)
		{
			if (success)
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}
			else
			{
                Console.ForegroundColor = ConsoleColor.Red;
            }
			Console.WriteLine(msg);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			PressEnterToContinue();
		}
		public string GetUserInput(string prompt)
		{
			Console.WriteLine($"Entery {prompt}");
			return Console.ReadLine();
		}
		public void PressEnterToContinue()
		{
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
        }
	}
}

