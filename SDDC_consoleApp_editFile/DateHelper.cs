using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDC_consoleApp_editFile
{
    public static class DateHelper
    {
        private static DayOfWeek firstDay = DayOfWeek.Sunday;
        private static CalendarWeekRule rule = CalendarWeekRule.FirstFullWeek;

        private static int _previousWeek;

        private static bool ParseWeekNumberToInt()
        {
            bool success = int.TryParse(Memory.WeekOfLastPart, out _previousWeek);
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForChangeWeek()
        {
            if (!ParseWeekNumberToInt())
                return false;

            int weakOfDay = 0;
            DateTime data;
            data = DateTime.Now;

            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            weakOfDay = cal.GetWeekOfYear(data, rule, firstDay);

            if (_previousWeek != weakOfDay)
            {
                Memory.IndexOfSerialNumber = "0";
                Memory.WeekOfLastPart = weakOfDay.ToString();

                FileMethods.SaveWeekMemoryFile(@"C:\SDCC_MEMORY\");

                
            }
            return true;
        }
    }
}
