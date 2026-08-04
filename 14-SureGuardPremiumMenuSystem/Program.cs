using System;

namespace SureGuardPremiumMenuSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int userChoice;

			do
			{
				Console.Clear();

				Console.WriteLine("=========================================");
				Console.WriteLine("      SureGuard | Premium Calculator");
				Console.WriteLine("=========================================");
				Console.WriteLine();
				Console.WriteLine("  [1] Vehicle Insurance");
				Console.WriteLine("  [2] Home Insurance");
				Console.WriteLine("  [3] Life Insurance");
				Console.WriteLine("  [0] Exit");
				Console.WriteLine();

				Console.Write("Enter your choice: ");
				userChoice = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine();

				switch (userChoice)
				{
					case 1:

						Console.Write("Enter vehicle value: ");
						double userVehicleValue = Convert.ToDouble(Console.ReadLine());

						Console.Write("Enter client age: ");
						int userAgeVehicleInsurance = Convert.ToInt32(Console.ReadLine());

						double baseVehiclePremium = userVehicleValue * 0.0025;

						double userAgeLoading = 0;

						if (userAgeVehicleInsurance < 25)
						{
							userAgeLoading = baseVehiclePremium * 0.20;
						}

						double userFinalPremium = baseVehiclePremium + userAgeLoading;
						double vat = userFinalPremium * 0.15;
						double totalPremium = userFinalPremium + vat;

						Console.WriteLine();
						Console.WriteLine($"Vehicle Value : R {userVehicleValue:F2}");
						Console.WriteLine($"Base Premium : R {baseVehiclePremium:F2}");
						Console.WriteLine($"Age Loading  : R {userAgeLoading:F2}");
						Console.WriteLine($"Final Premium: R {userFinalPremium:F2}");
						Console.WriteLine($"VAT (15%)    : R {vat:F2}");
						Console.WriteLine($"Total Premium: R {totalPremium:F2}");
						break;

					case 2:

						Console.Write("Enter home value: ");
						double userHomeValue = Convert.ToDouble(Console.ReadLine());

						Console.Write("Enter client age: ");
						int userAgeHomeInsurance = Convert.ToInt32(Console.ReadLine());

						double baseHomePremium = userHomeValue * 0.0005;
						double vatHome = baseHomePremium * 0.15;
						double totalHomePremium = baseHomePremium + vatHome;

						Console.WriteLine();
						Console.WriteLine($"Home Value   : R {userHomeValue:F2}");
						Console.WriteLine($"Base Premium : R {baseHomePremium:F2}");
						Console.WriteLine($"VAT (15%)    : R {vatHome:F2}");
						Console.WriteLine($"Total Premium: R {totalHomePremium:F2}");
						break;

					case 3:

						Console.Write("Enter cover amount: ");
						double userCoverAmount = Convert.ToDouble(Console.ReadLine());

						Console.Write("Enter client age: ");
						int userAgeLifeInsurance = Convert.ToInt32(Console.ReadLine());

						double baseLifePremium = userCoverAmount * 0.0003;
						double vatLife = baseLifePremium * 0.15;
						double totalLifePremium = baseLifePremium + vatLife;

						Console.WriteLine();
						Console.WriteLine($"Cover Amount : R {userCoverAmount:F2}");
						Console.WriteLine($"Base Premium : R {baseLifePremium:F2}");
						Console.WriteLine($"VAT (15%)    : R {vatLife:F2}");
						Console.WriteLine($"Total Premium: R {totalLifePremium:F2}");
						break;

					case 0:

						Console.WriteLine("Thank you for using SureGuard Premium Calculator.");
						break;

					default:

						Console.WriteLine("Invalid option. Please choose 0, 1, 2, or 3.");
						break;
				}

				if (userChoice != 0)
				{
					Console.WriteLine();
					Console.WriteLine("Press any key to return to the menu...");
					Console.ReadKey();
				}

			} while (userChoice != 0);
		}
	}
}