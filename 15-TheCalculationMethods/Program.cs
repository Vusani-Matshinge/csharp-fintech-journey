namespace TheCalculationMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string menuBorder = "=============================================";
			string menuTitle = "     SureGuard | Calculation Methods";

			Console.WriteLine(menuBorder);
			Console.WriteLine(menuTitle);
			Console.WriteLine(menuBorder);

			double vehicleValue = 450000;
			double homeValue = 1200000;
			double coverAmount = 2000000;

			Console.WriteLine($"Vehicle Premium:    R {CalculateVehiclePremium(vehicleValue):F2}");
			Console.WriteLine($"Home Premium:       R {CalculateHomePremium(homeValue):F2}");
			Console.WriteLine($"Life Premium:       R {CalculateLifePremium(coverAmount):F2}");

			double vehiclePremium = CalculateVehiclePremium(vehicleValue);
			double vat = CalculateVAT(vehiclePremium);

			Console.WriteLine($"VAT on Vehicle:     R {vat:F2}");
			Console.WriteLine($"Total Vehicle:      R {CalculateTotal(vehiclePremium, vat):F2}");

			Console.WriteLine(menuBorder);
		}

		static double CalculateVehiclePremium(double vehicleValue)
		{
			double vehicleRate = 0.0025;

			return vehicleValue * vehicleRate;
		}

		static double CalculateHomePremium(double homeValue)
		{
			double homeRate = 0.0005;

			return homeValue * homeRate;
		}

		static double CalculateLifePremium(double coverAmount)
		{
			double lifeRate = 0.0003;

			return coverAmount * lifeRate;
		}

		static double CalculateVAT(double premium)
		{
			double vatRate = 0.15;

			return premium * vatRate;
		}

		static double CalculateTotal(double premium, double vat)
		{
			return premium + vat;
		}
	}
}
