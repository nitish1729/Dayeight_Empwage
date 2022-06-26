public class Employee
{
    int WagePerHrs = 20;
    int FullTime = 8;
    int NoWork = 0;

    //void display()
    Employee()

    {
        Random ran = new Random();

        int AttenCheck = ran.Next(1, 10);

        if (AttenCheck == FullTime)
        {
            Console.WriteLine("Emp is Present");
            Console.WriteLine("EmpWage : " + (WagePerHrs * FullTime));
        }
        else
        {
            Console.WriteLine("Emp is Absent");
            Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
        }
    }
    public static void Main()
    {
        Employee wages = new Employee();
        // wages.display();
    }
}
