using System;
using System.Globalization;

namespace TheClientOnboardingConverter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Raw data from web form
			string rawName = "Sipho Dlamini";
			string rawAge = "27";
			string rawSalary = "45000.00";
			string rawLoanAmount = "150000.00";
			string rawCreditScore = "720";

			// UI elements
			string divider = "--------------------------------------------";
			string border = "============================================";
			string title = "     SureGuard | Client Onboarding Report";

			// Convert raw data to appropriate types
			int age = Convert.ToInt32(rawAge);
			double salary = Convert.ToDouble(rawSalary, CultureInfo.InvariantCulture);
			double loanAmount = Convert.ToDouble(rawLoanAmount, CultureInfo.InvariantCulture);
			int creditScore = Convert.ToInt32(rawCreditScore);

			// Calculate monthly salary and loan-to-salary ratio
			double monthlySalary = salary / 12;
			double loanToSalary = loanAmount / salary;
			double maxLoanToSalary = 4.50;
			bool isAffordable = loanToSalary <= maxLoanToSalary;

			// Output the report
			Console.WriteLine(border);
			Console.WriteLine(title);
			Console.WriteLine(border);

			Console.WriteLine($"Client Name:      {rawName}");
			Console.WriteLine($"Age:              {age}");
			Console.WriteLine($"Annual Salary:    R {salary:F2}");
			Console.WriteLine($"Monthly Salary:   R {monthlySalary:F2}");
			Console.WriteLine($"Loan Amount:      R {loanAmount:F2}");
			Console.WriteLine($"Credit Score:     {creditScore}");
			Console.WriteLine();

			Console.WriteLine(divider);
			Console.WriteLine("AFFORDABILITY CHECK");
			Console.WriteLine(divider);
			Console.WriteLine($"Loan-to-Salary:   {loanToSalary:F2}");
			Console.WriteLine($"Max Recommended:  {maxLoanToSalary:F2}");
			Console.WriteLine($"Affordable:       {isAffordable}");
		}
	}
}