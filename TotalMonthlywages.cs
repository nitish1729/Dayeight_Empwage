public class Employee
{

	const int MaxWorkingHrs = 100;
	const int WagePerHrs = 20;
	const int WorkingDay = 20;
	const int FullTime = 8;
	const int PartTime = 4;
	const int NoWork = 0;

	void display()
	{

		int totalWorkingDay = 0, totalEmpHrs = 0;
		while (totalEmpHrs <= MaxWorkingHrs && totalWorkingDay < WorkingDay)
		{
			totalWorkingDay++;
			Random random = new Random();
			int AttenCheck = random.Next(3, 10);
			switch (AttenCheck)
			{
				case 8:
					Console.WriteLine("Emp is present ");
					Console.WriteLine("Total Wage : " + (WagePerHrs * FullTime));
					break;

				case 4:
					Console.WriteLine("Emp is HalfDayWork ");
					Console.WriteLine("Total Wage : " + (WagePerHrs * PartTime));
					break;

				default:

					Console.WriteLine("Emp is Absent  ");
					Console.WriteLine("Total Wage : " + (WagePerHrs * NoWork));
					break;
			}
		}
	}
	public static void Main()
	{
		Employee totalwages = new Employee();
		totalwages.display();
	}

}