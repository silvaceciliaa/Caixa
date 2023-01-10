using System;
using System.Text;

namespace ATMapp.UI
{
	public class Utility
	{
        public string GetHiddenInput(string prompt)
		{
			bool isPrompt = true;
			string asterics = "";

			StringBuilder input = new StringBuilder();

			while (true)
			{
				if(isPrompt)
					Console.WriteLine(prompt);
                isPrompt = false;
                ConsoleKeyInfo inputKey = Console.ReadKey(true);

				if (inputKey.Key == ConsoleKey.Enter)
				{
					if (input.Length == 6)
					{
						break;
					}
					else
					{
						PrintMessage("\nPlease enter 6 digits", false);
                        input.Clear();
                        isPrompt = true;
						continue;
					}
				}
				if(inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
				{
					input.Remove(input.Length - 1, 1);
				}
				else if (inputKey.Key != ConsoleKey.Backspace)
				{
					input.Append(inputKey.KeyChar);
					Console.Write(asterics + "*");
				}
			}
            return input.ToString();
        }
		public void PrintMessage(string msg, bool success = true)
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
		}
		public string GetUserInput(string prompt)
		{
			Console.WriteLine($"Enter {prompt}");
			return Console.ReadLine();
		}

		public void PrintDoAnimation(int timer = 10)
		{
			for(int i = 0; i < timer; i++)
			{
				Console.WriteLine(".");
				Thread.Sleep(200);
			}
			Console.Clear();
		}
		public void PressEnterToContinue()
		{
            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();
        }
	}
}

