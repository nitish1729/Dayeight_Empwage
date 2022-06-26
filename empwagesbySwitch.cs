public class Employee
{
	int WagePerHrs = 20;
	int FullTime = 8;
	int PartTime = 4;
	int NoWork = 0;


	void display()

	{
		Random ran = new Random();

		int AttenCheck = ran.Next(1, 10);

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
	public static void Main()
	{
		Employee wages = new Employee();
		wages.display();
	}
}