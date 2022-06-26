public class Employee
{
	 int present = 1;
	 void display()
	 {

		Random ran = new Random();
		int AttenCheck = ran.Next(0, 2);
		if (AttenCheck == present)
		{
			Console.WriteLine("Emp is Present");
		}
		else
		{
			Console.WriteLine("Emp is Absent");
		}
	 }
	 public static void Main()
	 {
		Employee check = new Employee();
		check.display();
	 }
}