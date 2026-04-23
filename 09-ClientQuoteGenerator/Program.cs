using System.Globalization;

namespace ClientQuoteGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//UI elements
			string border = "=============================================";
			string dashboardMessage = "      SureGuard | Vehicle Insurance Quote";
			string quoteMessage = "           YOUR INSURANCE QUOTE";
			string bannerMessage = "Thank you for using SureGuard Insurance!";

			//Data elements
			string userName;
			int userAge;
			double vehicleValue;
			double premiumRate = 0.0025;
			double vatRate = 0.15;


			//Display dashboard
			Console.WriteLine(border);
			Console.WriteLine(dashboardMessage);
			Console.WriteLine(border);

			Console.Write("Please enter your full name: ");
			userName = Console.ReadLine();

			Console.Write("Please enter your age: ");
			userAge = Convert.ToInt32(Console.ReadLine());

			Console.Write("Please enter the value of your vehicle: ");
			vehicleValue = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

			//Calculate premium,VAT and total quote
			double basePremium = vehicleValue * premiumRate;
			double vatAmount = basePremium * vatRate;
			double totalQuote = basePremium + vatAmount;

			Console.WriteLine(border);
			Console.WriteLine(quoteMessage);
			Console.WriteLine(border);

			Console.WriteLine($"Client:          {userName}");
			Console.WriteLine($"Age:             {userAge}");
			Console.WriteLine($"Vehicle Value:   R {vehicleValue:F2}");
			Console.WriteLine($"Base Premium:    R {basePremium:F2}");
			Console.WriteLine($"VAT (15%):       R {vatAmount:F2}");
			Console.WriteLine($"Total Payable:   R {totalQuote:F2}");

			Console.WriteLine(border);
			Console.WriteLine(bannerMessage);
			Console.WriteLine(border);
		}
	}
}
