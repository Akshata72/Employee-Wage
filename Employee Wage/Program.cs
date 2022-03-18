int Present = 1;
Random random = new Random();
int employee_status = random.Next(0, 2);
if (employee_status == Present)
{
    Console.WriteLine("Employeee is Present");

}
else
{
    Console.WriteLine("Employee is Absent");

}