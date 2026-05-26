namespace CreditScoreEvaluator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string border = "=====================================";
			string welcomeMessage = "   SureGuard | Credit Score Check";

			Console.WriteLine(border);
			Console.WriteLine(welcomeMessage);
			Console.WriteLine(border);

			Console.Write("Enter your credit score: ");
			int creditScore = Convert.ToInt32(Console.ReadLine());

			string rating;

			if (creditScore >= 800)
			{
				rating = "Excellent";
			}
			else if (creditScore >= 700)
			{
				rating = "Good";
			}
			else if (creditScore >= 600)
			{
				rating = "Fair";
			}
			else if (creditScore >= 500)
			{
				rating = "Poor";
			}
			else
			{
				rating = "Very Poor";
			}

			string loanEligibility = (creditScore >= 600) ? "Eligible" : "Not Eligible";

			Console.WriteLine();
			Console.WriteLine(border);
			Console.WriteLine($"Score:       {creditScore}");
			Console.WriteLine($"Rating:      {rating}");
			Console.WriteLine($"Loan Access: {loanEligibility}");
			Console.WriteLine(border);
		}
	}
}
