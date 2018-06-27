using System;

namespace Date
{
    public class Date
    {
        private int month, day, year;

        public int Month
        {
            get { return month; }
            set
            {
                if (month <= 0) throw new ArgumentOutOfRangeException("Cannot enter a negative number.");
                else month = value;
            }
        }//end month property

        public int Day
        {
            get { return day; }
            set
            {
                if (day <= 0) throw new ArgumentOutOfRangeException("Cannot enter a negative number.");
                else day = value;
            }
        }//end day property
              
        public int Year
        {
            get { return year; }
            set
            {
                if (year <= 0) throw new ArgumentOutOfRangeException("Cannot enter a negative number.");
                else year = value;
            }
        }//end year property

        public Date(int consMonth,int consDay,int consYear) {
            month = consMonth;
            day = consDay;
            year = consYear;
        }//end constructor
        
        public string DisplayDate(int paramMonth, int paramDay, int paramYear) {
            int methMonth, methDay, methYear;

            methMonth = month; methDay = day; methYear = year;
            string strMonth = Convert.ToString(methMonth); string strDay = Convert.ToString(methDay); string strYear = Convert.ToString(methYear);
            string FullDate = strMonth + '/' + strDay + '/' + strYear;
            return FullDate;
            
        }//end method

    }//end class
}//end namespace
