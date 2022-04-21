using System;
using System.Collections.Generic;
using LibraryData.Models;

namespace LibraryServices
{
    public class DataHelpers
    {
        public static List<string> HumaniseBusinessHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();

            foreach(var time in branchHours)
            {
                var day = HumaniseDay(time.DayOfWeek);
                var openTime = HumaniseTime(time.OpenTime);
                var closeTime = HumaniseTime(time.CloseTime);

                var timeEntry = $"{day} {openTime} to {closeTime}";

                hours.Add(timeEntry);
            }

            return hours;
        }

        public static string HumaniseDay(int number)
        {
            return Enum.GetName(typeof(DayOfWeek), number);
        }

        public static string HumaniseTime(int time)
        {
            return TimeSpan.FromHours(time).ToString("hh' : 'mm");
        }
    }
}
