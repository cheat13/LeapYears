using System;

namespace LeapYear.lib
{
    public class LeapYears
    {
        public string CheckLeapYears(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? "leap year" : "not leap year" ;
        }
    }
}
