namespace EmployeeWageUC6
{
    class program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_HR_PER_RATE = 20;
        public const int NUM_OF_WORKING_DAY = 20;
        public const int MAX_HR_MONTH = 100;

        static void Main(string[] args)
        {
            int empHr = 0;
            int empwage = 0;
            int TotalEmpHr = 0;
            int totalworkingdays = 0;
            while (TotalEmpHr < MAX_HR_MONTH && totalworkingdays < NUM_OF_WORKING_DAY)
            {
                totalworkingdays++;
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
                TotalEmpHr += empHr;

                Console.WriteLine("Day=" + totalworkingdays + "emphrs" + empHr);
            }
            int totalempwage = (EMP_HR_PER_RATE * TotalEmpHr);
            Console.WriteLine("Total Emp Wage:" + totalempwage);
        }



    }
}