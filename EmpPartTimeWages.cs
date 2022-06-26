 
public class Employee
 {
    int WagePerHrs = 20;
    int FullTime = 8;
    int partTime = 4;
    int NoWork = 0;

    public void display()

      {
        
        Random ran = new Random();

        int AttenCheck = ran.Next(0,9);

        if(AttenCheck == FullTime)
        {
            Console.WriteLine("Emp is Present");
            Console.WriteLine("EmpWage : "+(WagePerHrs * FullTime));
        }

        else if (AttenCheck == partTime)
        {
            Console.WriteLine("Emp is present for HalfDay");
            Console.WriteLine("EmpWage : " + (WagePerHrs * partTime));
        }

        else
        {
            Console.WriteLine("Emp is Absent");
            Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
        }
     }
      public static void Main(string[] args)
      {
        Employee wages = new Employee();

        wages.display();
      }
}
