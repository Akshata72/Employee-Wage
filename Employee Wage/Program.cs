int Present = 1;
int Emp_per_rate = 20;
int emphr = 0;
int empwage = 0;
Random random = new Random();
int employee_status = random.Next(0, 2);
if (employee_status == Present)
{
    Console.WriteLine("Employeee is Present");
    emphr = 8;
}
else
{
    Console.WriteLine("Employee is Absent");
    emphr = 0;
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Daily wage" + empwage);