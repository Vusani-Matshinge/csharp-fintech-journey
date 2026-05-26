using System.Globalization;

namespace LoanApplicationAssessor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string border = "=============================================";
			string divider = "---------------------------------------------";
			string loanApplicationMessage = "      SureGuard | Loan Application";
			string assessmentResultsMessage = "       SureGuard | Assessment Result";
			string decisionMessage = "DECISION";

			Console.WriteLine(border);
			Console.WriteLine(loanApplicationMessage);
			Console.WriteLine(border);

			Console.Write("Enter your name: ");
			string userName = Console.ReadLine();

			Console.Write("Enter your age: ");
			int userAge = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter your annual salary: ");
			double userSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Enter your loan amount: ");
			double loanAmount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Enter your credit score: ");
			int creditScore = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine();

			Console.WriteLine(border);
			Console.WriteLine(assessmentResultsMessage);
			Console.WriteLine(border);

			double salaryToLoanRatio = loanAmount / userSalary;
			Console.WriteLine($"Client:         {userName}");
			Console.WriteLine($"Age:            {userAge}");
			Console.WriteLine($"Annual Salary:  R {userSalary:F2}");
			Console.WriteLine($"Loan Amount:    R {loanAmount:F2}");
			Console.WriteLine($"Credit Score:   {creditScore}");
			Console.WriteLine($"Loan-to-Salary: {salaryToLoanRatio:F2}");

			Console.WriteLine();

			Console.WriteLine(divider);
			Console.WriteLine(decisionMessage);
			Console.WriteLine(divider);

			bool ageCheck = userAge >= 18;
			bool creditCheck = creditScore >= 600;
			bool affordabilityCheck = salaryToLoanRatio <= 5.0;

			string ageCheckLabel = ageCheck ? "Passed" : "Failed";
			string creditCheckLabel = creditCheck ? "Passed" : "Failed";
			string affordabilityCheckLabel = affordabilityCheck ? "Passed" : "Failed";

			string statusCheck = (ageCheck && creditCheck && affordabilityCheck) ? "APPROVED" : "DECLINED";

			Console.WriteLine($"Age Check:      {ageCheck}");
			Console.WriteLine($"Credit Check:   {creditCheck}");
			Console.WriteLine($"Affordability:  {affordabilityCheck}");

			Console.WriteLine(divider);

			Console.WriteLine($"Status:         {statusCheck}");

			Console.WriteLine(border);
		}
	}
}
