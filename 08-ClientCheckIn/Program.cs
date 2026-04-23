using System;

namespace ClientCheck_In
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			string border = "=======================================";
			string divider = "---------------------------------------";
			string welcomeMessage = "     Welcome to SureGuard Insurance";
			string userName;
			int userAge;

			Console.WriteLine(border);
			Console.WriteLine(welcomeMessage);
			Console.WriteLine(border);

			Console.Write("Please enter your name: ");
			userName = Console.ReadLine();

			Console.Write("Please enter your age: ");
			userAge = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine(divider);
			Console.WriteLine($"Hello, {userName}!");
			Console.WriteLine($"You are {userAge} years old.");
			Console.WriteLine("Your profile has been created.");
			Console.WriteLine(border);
		}
	}
}