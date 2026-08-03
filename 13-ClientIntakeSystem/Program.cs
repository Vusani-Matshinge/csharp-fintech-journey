
using System.Globalization;

namespace ClientIntakeSystem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exit Condtion for my do while loop. I will use a boolean variable to determine if the user wants to add another client or not.
			bool clientAddAnotherClientChoice;

			// Display a welcome message for the client intake system.
			string forgeDigitalClientIntakeWelcomeMessage = "    Forge Digital | Client Intake";
			string forgeDigitalClientIntakeWelcomeMessageBorder = "=========================================";
			string forgeDigitalClientIntakeClientSummary = "         Client Summary";

			do
			{

				//Use Consoles Readline() method to get user input for the client intake system. I will use the iteration statement while to validate the age of the client. If the client is under 18, I will prompt the user to enter a valid age.
				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessageBorder);
				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessage);
				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessageBorder);

				Console.Write("Enter client name: ");
				string clientName = Console.ReadLine();

				Console.Write("Enter age: ");
				int clientAge = Convert.ToInt32(Console.ReadLine());

				//int attemptCount = 0;

				while (clientAge < 18)
				{
					//attemptCount++;
					Console.WriteLine($"Age must be 18 or above. Try again.");
					Console.Write("Enter age: ");
					clientAge = Convert.ToInt32(Console.ReadLine());
				}

				Console.Write("Enter annual salary: ");
				double clientAnnualSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

				Console.Write("Is this a premium client? (yes/no):");
				string clientHasPremiumStatusInput = Console.ReadLine();

				bool clientHasPremiumStatus = clientHasPremiumStatusInput.ToLower() == "yes";

				Console.WriteLine();


				// Calculate the monthly salary of the client based on the annual salary.
				double clientMonthlySalary = clientAnnualSalary / 12;

				//Display the client summary in the console. 
				string incomeBand = "";

				if (clientAnnualSalary > 500000)
				{
					incomeBand = "High Income";
				}
				else if (clientAnnualSalary >= 150000)
				{
					incomeBand = "Middle Income";
				}
				else
				{
					incomeBand = "Entry Level";
				}

				Console.WriteLine();

				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessageBorder);
				Console.WriteLine(forgeDigitalClientIntakeClientSummary);
				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessageBorder);

				Console.WriteLine($"Name:           {clientName}");
				Console.WriteLine($"Age:            {clientAge}");
				Console.WriteLine($"Annual Salary:  R{clientAnnualSalary:F2}");
				Console.WriteLine($"Monthly Salary: R{clientMonthlySalary:F2}");
				Console.WriteLine($"Premium Status: {clientHasPremiumStatus}");
				Console.WriteLine($"Income Band:    {incomeBand}");

				Console.WriteLine(forgeDigitalClientIntakeWelcomeMessageBorder);

				// Wait for user input before closing the console window. See if they wish to add another client. If they do, repeat the process. If not, exit the program.

				Console.Write("Add another client? (yes/no): ");
				string clientAddAnotherClientChoiceInput = Console.ReadLine();

				clientAddAnotherClientChoice = clientAddAnotherClientChoiceInput.ToLower() == "yes";

			} while (clientAddAnotherClientChoice);


			Console.WriteLine("Thank you for using Forge Digital.");
			Console.WriteLine("=========================================");

		}
	}
}
