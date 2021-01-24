namespace XComIIEdit.Lib
{
    public class Time
    {
        public int Second { get; set; }
        public int Minute { get; set; }
        public int Hour { get; set; }
        public int Weekday { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Time(int second, int minute, int hour, int weekday, int day, int month, int year)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
            Weekday = weekday;
            Day = day;
            Month = month;
            Year = year;
        }

        public Time()
        {
            Second = 1;
            Minute = 1;
            Hour = 12;
            Weekday = 6;
            Day = 1;
            Month = 1;
            Year = 199;
        }
    }
}