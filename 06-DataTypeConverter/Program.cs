using System.Globalization;

namespace DataTypeConverter

{
	internal class Program
	{
		static void Main(string[] args)
		{
			//String representations of different data types
			string strAge = "34";
			string strHeight = "1.72";
			string strSalary = "25000.50";
			string strIsActive = "true";

			//Type conversion using Convert class
			int age = Convert.ToInt32(strAge);
			double height = Convert.ToDouble(strHeight, CultureInfo.InvariantCulture);
			double salary = Convert.ToDouble(strSalary, CultureInfo.InvariantCulture);
			bool isActive = Convert.ToBoolean(strIsActive);

			//Calculations using the converted values
			int ageNextYear = age + 1;
			double monthlySalary = salary / 12;

			//UI elements for displaying results
			string heading = "===== Converted Client Data =====";
			string border = "=================================";

			//Output the results
			Console.WriteLine(heading);
			Console.WriteLine($"Age:      {age}        (int)");
			Console.WriteLine($"Height:   {height:F2}      (double)");
			Console.WriteLine($"Salary:   R {salary:F2} (double)");
			Console.WriteLine($"Active:   {isActive}      (bool)");
			Console.WriteLine(border);
			Console.WriteLine($"Age next year:    {ageNextYear}");
			Console.WriteLine($"Monthly Salary:   R {monthlySalary:F2}");
			Console.WriteLine(border);
		}
	}
}
