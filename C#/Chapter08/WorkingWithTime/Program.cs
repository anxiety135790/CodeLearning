using static System.Console;
using System;
using System.Globalization;



namespace WorkingWithTime
{
    internal class Program
    {
        public Program()
        {
        }

        private static void Main(string[] args)
        {
            WriteLine("Earliest date/time value is: {0}",
    arg0: DateTime.MinValue);

            WriteLine("UNIX epoch date/time value is {0}",
            arg0: DateTime.UnixEpoch);

            WriteLine("Date/time value Now is: {0}",
            arg0: DateTime.Now);

            WriteLine("Date/time value Today is: {0}",
            arg0: DateTime.Today);
            /*
            output:
            Earliest date/time value is: 1/1/0001 12:00:00 AM
            UNIX epoch date/time value is 1/1/1970 12:00:00 AM
            Date/time value Now is: 6/13/2022 2:49:11 PM
            Date/time value Today is: 6/13/2022 12:00:00 AM
            */


            DateTime christmas = new(year: 2021, month: 12, day: 25);

            WriteLine("Christmas: {0}",
            arg0: christmas);

            WriteLine("Christmas: {0:dddd, dd MMMM yyyy}",
            arg0: christmas);

            WriteLine("Christmas is in month {0} of the year.",
            arg0: christmas.Month);

            WriteLine("Christmas is day {0} of the year.",
            arg0: christmas.DayOfYear);

            WriteLine("Christmas {0} is on a {1}.",
            arg0: christmas.Year,
            arg1: christmas.DayOfWeek);
            /*
            output:
            Christmas: Saturday, 25 December 2021
            Christmas is in month 12 of the year.
            Christmas is day 359 of the year.
            Christmas 2021 is on a Saturday.
            */


            DateTime beforeXmas = christmas.Subtract(value: TimeSpan.FromDays(value: 12));
            DateTime afterXmas = christmas.AddDays(value: 12);

            WriteLine(format: "12 days before Christmas is: {0}",
            arg0: beforeXmas);

            WriteLine(format: "12 days after Christmas is: {0}",
            arg0: afterXmas);

            TimeSpan untilChristmas = christmas - DateTime.Now;

            WriteLine(format: "There are {0} days and {1} hours until Christmas.",
            arg0: untilChristmas.Days,
            arg1: untilChristmas.Hours);

            WriteLine("There are {0:N0} hours until Christmas.",
            arg0: untilChristmas.TotalHours);
            /*
            output:
            12 days before Christmas is: 12/13/2021 12:00:00 AM
            12 days after Christmas is: 1/6/2022 12:00:00 AM
            There are -170 days and -15 hours until Christmas.
            There are -4,096 hours until Christmas.
            */


            DateTime kidWakeUp = new(
                year: 2021, month: 12, day: 25,
                hour: 6, minute: 30, second: 0);

            WriteLine(format: "Kids wake up on Christmas: {0}",
            arg0: kidWakeUp);

            WriteLine(format: "The kids woke me up at {0}",
            arg0: kidWakeUp.ToShortTimeString());
            /*
            output:
            Kids wake up on Christmas: 25/12/2021 06:30:00
            The kids woke me up at 06:30
            */

            WriteLine("Current culture is: {0}",
            arg0: CultureInfo.CurrentCulture.Name);

            string textDate = " 4 July 2021";
            DateTime independencyDay = DateTime.Parse(textDate);

            WriteLine("Text: {0}, DateTime: {1:d MMMM}",
            arg0: textDate,
            arg1: independencyDay);

            textDate = "7/4/2021";
            independencyDay = DateTime.Parse(textDate);

            WriteLine(format: "Text: {0}, DateTime: {1:d MMMM}",
            arg0: textDate,
            arg1: independencyDay);

            independencyDay = DateTime.Parse(textDate,
            provider: CultureInfo.GetCultureInfo(name: "en-US"));

            WriteLine("Text: {0}, DateTime: {1:d MMMM}",
            arg0: textDate,
            arg1: independencyDay);
            /*
            output:
            Current culture is: "Your current culture"
            Text:  4 July 2021, DateTime: 4 July
            Text: 7/4/2021, DateTime: 4 July
            Text: 7/4/2021, DateTime: 4 July
            */



            for (int year = 2020; year < 2026; year++)
            {
                Write($"{year} is a leap year: {DateTime.IsLeapYear(year)}.");
                WriteLine("There are {0} days in February {1}",
                arg0: (byte)DateTime.DaysInMonth(year: year, month: 2),
                arg1: year);

            }

            WriteLine("Is Christmas daylight saving time? {0}",
            arg0: christmas.IsDaylightSavingTime());

            WriteLine("Is July 4th daylight sacing time? {0}",
            arg0: independencyDay.IsDaylightSavingTime());
            /*
            output:
            2020 is a leap year: True.There are 29 days in February 2020
            2021 is a leap year: False.There are 28 days in February 2021
            2022 is a leap year: False.There are 28 days in February 2022
            2023 is a leap year: False.There are 28 days in February 2023
            2024 is a leap year: True.There are 29 days in February 2024
            2025 is a leap year: False.There are 28 days in February 2025
            Is Christmas daylight saving time? False
            Is July 4th daylight sacing time? False
            */



            DateOnly queensBirthday = new(year: DateTime.Now.Year + 1, month: 04, day: 21);
            WriteLine($"The Queen's next birthday is on {queensBirthday}");

            TimeOnly partyStarts = new(hour: 20, minute: 30);
            WriteLine($"The Queen's party starts at {partyStarts}.");

            DateTime calendarEntry = queensBirthday.ToDateTime(partyStarts);
            WriteLine($"Add to your calendar: {calendarEntry}.");
        }

     
    }
}