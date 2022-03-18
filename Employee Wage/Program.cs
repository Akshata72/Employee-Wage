namespace EmployeeWageUC5
{
    class program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_HR_PER_RATE = 20;
        public const int NUM_OF_WORKING_DAY = 20;

        static void Main(string[] args)
        {
            int empHr = 0;
            int empwage = 0;
            int TotalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                empwage = (EMP_HR_PER_RATE * empHr);
                TotalEmpWage += empwage;
                Console.WriteLine("Daily employee wage:" + empwage);
            }
            Console.WriteLine("Total Emp Wage:" + TotalEmpWage);
        }



    }
}