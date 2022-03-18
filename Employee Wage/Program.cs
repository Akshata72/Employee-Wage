namespace EmployeeWage
{

    class Company
    {
        public float EmpWorkingHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHrs_PerDay = 4;
        public int MAX_WORKING_HR = 100;
        public int MAX_WORKING_DAY = 20;
        public String CompanyName;

        public Company(string CompanyName, int EmpWorkingHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HR, int MAX_WORKING_DAY)
        {
            this.CompanyName = CompanyName;
            this.EmpWorkingHour = EmpWorkingHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
            this.MAX_WORKING_HR = MAX_WORKING_HR;
            this.MAX_WORKING_DAY = MAX_WORKING_DAY;

        }

    }


    class Employeewagecomputation
    {

        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        private float TotalWage = 0;
        private Dictionary<String, Company> Companies = new Dictionary<String, Company>();

        private void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HR, int MAX_WORKING_DAY)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkingHrs_PerDay, PartTime_WorkingHrs_PerDay, MAX_WORKING_HR, MAX_WORKING_DAY);
            Companies.Add(CompanyName.ToLower(), company);
        }




        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);

        }



        public void CalculateEmpWage(string CompanyName)
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;

            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("company don't exist");
            Companies.TryGetValue(CompanyName.ToLower(), out Company company);

            while (DayNumber <= company.MAX_WORKING_DAY && TotalWorkingHrs <= company.MAX_WORKING_HR)
            {

                switch (IsEmployeePresent())
                {
                    case IS_PART_TIME:
                        EmpWorkingHrs = company.PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = company.FullTime_WorkingHrs_PerDay;
                        break;
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWorkingHour;
                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;

            }
            Console.WriteLine("Company name:" + CompanyName);
            Console.WriteLine("TotalWorkingHrs working days :" + (DayNumber) + "\nTotal working hours:" + TotalWorkingHrs + "\nTotal employee wage:" + TotalWage);


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage calculatin");

            Employeewagecomputation employeeWageComputation = new Employeewagecomputation();
            employeeWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeWageComputation.AddCompany("Mahindra", 30, 8, 4, 100, 20);
            employeeWageComputation.CalculateEmpWage("TATA");
            employeeWageComputation.CalculateEmpWage("Mahindra");



        }

    }

}
