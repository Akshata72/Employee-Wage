namespace EmployeeWageUC4
{
    class program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_HR_PER_RATE = 20;


        static void Main(string[] args)
        {
            int empHr = 0;
            int empwage = 0;
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
            Console.WriteLine("Daily employee wage:" + empwage);
        }



    }
}