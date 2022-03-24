class CompanyEmpWage
{
    float EmpRatePerHour = 20;
    public int FullTime_WorkingHrs_PerDay = 8;
    public int PartTime_WorkingHrs_PerDay = 4;
    public int MAX_WORKING_HR = 100;
    public int MAX_WORKING_DAY = 20;
    public const int IS_FULL_TIME = 1;
    public const int IS_PART_TIME = 2;
    public const int IS_ABSENT = 0;
    float EmpDailyWage = 0;
    public int EmpWagePerHour = 0;
    public string Company;
    public CompanyEmpWage(string Company,int EmpRatePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHrs_PerDay, int MAX_WORKING_HR, int MAX_WORKING_DAY)
    {
        this.Company = Company;
        this.EmpRatePerHour = EmpRatePerHour;
        this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
        this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHrs_PerDay;
        this.MAX_WORKING_HR = MAX_WORKING_HR;
        this.MAX_WORKING_DAY = MAX_WORKING_DAY;
    }
    private int IsEmployeePresent()
    {
        Random random = new Random();
        int empcheck = random.Next(0, 3);
        return empcheck;
    }
    public void CalculateWage(string Company)
    {
        float TotalWage = 0;
        int DayNumber = 1;
        int EmpWorkingHrs = 0;
        int TotalWorkingHrs = 0;
        while (DayNumber < MAX_WORKING_DAY && TotalWorkingHrs < MAX_WORKING_HR)
        {
            switch (IsEmployeePresent())
            {
                case IS_PART_TIME:
                    EmpWorkingHrs = PartTime_WorkingHrs_PerDay;
                    break;
                case IS_FULL_TIME:
                    EmpWorkingHrs = FullTime_WorkingHrs_PerDay;
                    break;
                case IS_ABSENT:
                    EmpWorkingHrs = 0;
                    break;
            }
            EmpDailyWage = (EmpWorkingHrs * EmpRatePerHour);
            TotalWage += EmpDailyWage;
            DayNumber++;
            TotalWorkingHrs += EmpWorkingHrs;
        }
        Console.WriteLine("TotalWorkingHrs working days :" + (DayNumber ) + "\nTotal working hours:" + TotalWorkingHrs);
        Console.WriteLine("Total Employee Wage For " +Company +" Company = " + TotalWage);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to employee wage calculatin");
        CompanyEmpWage dMart = new CompanyEmpWage("dMart",20, 8, 4, 100, 20);
        dMart.CalculateWage("dMart");
        CompanyEmpWage TATA = new CompanyEmpWage("TATA", 20, 6, 4, 100, 20);
        TATA.CalculateWage("TATA");
    }
}