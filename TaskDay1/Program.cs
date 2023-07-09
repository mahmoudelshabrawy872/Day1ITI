namespace TaskDay1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
            ///////////////////////////////////////////
            int result1 = -1 + 4 * 6;
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"Result 1: {result1}");
            Console.WriteLine($"Result 2: {result2}");
            Console.WriteLine($"Result 3: {result3}");
            Console.WriteLine($"Result 4: {result4}");
            //////////////////////////////////////////////////
            ///

            Console.WriteLine("Please enter your birth year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your birth month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your birth day:");
            int day = Convert.ToInt32(Console.ReadLine());

            if (ValidateDate(year, month, day))
            {
                DateTime birthDate = new DateTime(year, month, day);
                DateTime currentDate = DateTime.Now;

                int ageInYears = currentDate.Year - birthDate.Year;
                int ageInMonths = currentDate.Month - birthDate.Month;
                int ageInDays = currentDate.Day - birthDate.Day;

                if (ageInDays < 0)
                {
                    ageInMonths--;
                    ageInDays += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
                }

                if (ageInMonths < 0)
                {
                    ageInYears--;
                    ageInMonths += 12;
                }

                Console.WriteLine($"You're {ageInYears} years, {ageInMonths} months, and {ageInDays} days old.");
            }
        }
        static bool ValidateDate(int year, int month, int day)
        {
            if (year < 1)
            {
                Console.WriteLine("Invalid year!");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month!");
                return false;
            }

            int daysInMonth;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = DateTime.IsLeapYear(year) ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    return false;
            }

            if (day < 1 || day > daysInMonth)
            {
                Console.WriteLine("Invalid day!");
                return false;
            }

            return true;
        }


    }
}