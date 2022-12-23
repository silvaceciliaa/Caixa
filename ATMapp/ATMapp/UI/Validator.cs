using System;
using System.ComponentModel;

namespace ATMapp.UI
{
	public class Validator
	{

        public T Convert<T>(string prompt)
		{
            var utility2 = new Utility();

            bool valid = false;
			string userInput;

			while(!valid)
			{
				userInput = utility2.GetUserInput(prompt);

				try
				{
					var converter = TypeDescriptor.GetConverter(typeof(T));
					if(converter != null)
					{
						return (T)converter.ConvertFromString(userInput);
					}
					else
					{
						return default;
					}
				}
				catch
				{
					utility2.PrintMessage("Invalid input. Try again.", false);
				}
			}
			return default;

		}
	}
}

