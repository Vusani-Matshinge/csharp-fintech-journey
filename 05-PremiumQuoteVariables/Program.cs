namespace PremiumQuoteVariables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string divider = "======================================";
			string dashboard = "       SureGuard | Premium Quote";
			string banner = "Quote valid for 30 days.";
			string clientName = "Lebo Dlamini";
			string policyType = "Vehicle Insurance";
			double vehicleValue = 750000.00;
			int riskRating = 3;
			double premiumRate = 0.0025;
			double vatRate = 0.15;
			double monthlyPremium;
			double VAT;
			double totalPayable;

			monthlyPremium = vehicleValue * premiumRate;
			VAT = monthlyPremium * vatRate;
			totalPayable = VAT + monthlyPremium;

			Console.WriteLine(divider);
			Console.WriteLine(dashboard);
			Console.WriteLine(divider);
			Console.WriteLine($"Client:          {clientName}");
			Console.WriteLine($"Policy Type:     {policyType}");
			Console.WriteLine($"Vehicle Value:   {vehicleValue:F2}");
			Console.WriteLine($"Risk Rating:     {riskRating}");
			Console.WriteLine($"Monthly Premium: {monthlyPremium:F2}");
			Console.WriteLine($"VAT (15%):       {VAT:F2}");
			Console.WriteLine($"Total Payable:   {totalPayable:F2}");
			Console.WriteLine(divider);
			Console.WriteLine(banner);
			Console.WriteLine(divider);
		}
	}
}
