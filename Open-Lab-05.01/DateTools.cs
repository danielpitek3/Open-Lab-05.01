using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            if (year <= 0)
                return "0 and negative is not allow for a year";
             
            else if (year <= 100)
                return "1st century";

            else if (year % 100 == 0)
                return year / 100 + "th century";
            else
                return year / 100 + 1 + "th century";
        }
    }
}
