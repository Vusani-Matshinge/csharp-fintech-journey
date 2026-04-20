namespace ClientProfile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string dashboardWelcomeMessage = "===== SureGuard Client Profile =====";
			string divider = "=====================================";
			string clientName = "Lebo Dlamini";
			int clientAge = 34;
			double clientHeight = 1.72;
			bool active = true;

			Console.WriteLine(dashboardWelcomeMessage);
			Console.WriteLine($"Name:     {clientName}");
			Console.WriteLine($"Age:      {clientAge}");
			Console.WriteLine($"Height:   {clientHeight}");
			Console.WriteLine($"Active:   {active}");
			Console.WriteLine(divider);

		}
	}
}
