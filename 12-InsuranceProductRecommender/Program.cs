using System.Globalization;

namespace InsuranceProductRecommender
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string border = "==============================================";
			string divider = "----------------------------------------------";
			string productRecommendation = "     SureGuard | Product Recommender";
			string userRecommendation = "     SureGuard | Your Recommendations";
			string recommendedProducts = "RECOMMENDED PRODUCTS";
			string financialHealth = "FINANCIAL HEALTH";

			Console.WriteLine(border);
			Console.WriteLine(productRecommendation);
			Console.WriteLine(border);

			Console.Write("Enter your name: ");
			string userName = Console.ReadLine();

			Console.Write("Enter your age: ");
			int userAge = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your annual salary: R: ");
			double userSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Do you own a vehicle? (yes/no): ");
			bool ownsVehicle = Console.ReadLine().ToLower() == "yes";

			Console.Write("Do you own a home? (yes/no): ");
			bool ownsHome = Console.ReadLine().ToLower() == "yes";

			Console.Write("Do you have dependants? (yes/no): ");
			bool hasDependants = Console.ReadLine().ToLower() == "yes";

			Console.WriteLine();

			Console.WriteLine(border);
			Console.WriteLine(userRecommendation);
			Console.WriteLine(border);

			Console.WriteLine($"Client:         {userName}");
			Console.WriteLine($"Age:            {userAge}");
			Console.WriteLine($"Annual Salary:  R {userSalary:F2}");

			Console.WriteLine();

			Console.WriteLine(divider);
			Console.WriteLine(recommendedProducts);
			Console.WriteLine(divider);

			bool vehicleInsuranceRecommened = ownsVehicle;
			bool homeInsuranceRecommened = ownsHome;
			bool lifeInsuranceRecommened = hasDependants;
			bool medicalAidRecommended = userAge < 30 && userSalary > 120000;
			bool funeralCoverRecommended = hasDependants || userAge >= 40;

			string vehicleInsuranceLabel = vehicleInsuranceRecommened ? "Recommended" : "Not Applicable";
			string homeInsuranceLabel = homeInsuranceRecommened ? "Recommended" : "Not Applicable";
			string lifeInsuranceLabel = lifeInsuranceRecommened ? "Recommended" : "Optional";
			string medicalAidLabel = medicalAidRecommended ? "Recommended" : "Consider";
			string funeralCoverLabel = funeralCoverRecommended ? "Recommended" : "Optional";

			Console.WriteLine($"Vehicle Insurance:  {vehicleInsuranceLabel}");
			Console.WriteLine($"Home Insurance:     {homeInsuranceLabel}");
			Console.WriteLine($"Life Insurance:     {lifeInsuranceLabel}");
			Console.WriteLine($"Medical Aid:        {medicalAidLabel}");
			Console.WriteLine($"Funeral Cover:      {funeralCoverLabel}");

			Console.WriteLine(divider);
			Console.WriteLine(financialHealth);
			Console.WriteLine(divider);

			string incomeBand;
			double monthlySalary = userSalary / 12;
			double savingPotential = monthlySalary * 0.15;

			if (userSalary > 500000)
			{
				incomeBand = "High Income";
			}
			else if (userSalary >= 150000)
			{
				incomeBand = "Middle Income";
			}
			else
			{
				incomeBand = "Entry Level";
			}


			Console.WriteLine($"Income Band:        {incomeBand}");
			Console.WriteLine($"Savings Potential:  R {savingPotential:F2} per month");

			Console.WriteLine(divider);

		}
	}
}
