namespace OpenXComEdit.Lib
{
    public class Death
    {
        public Time Time { get; set; }
        public Kill Cause { get; set; }

        public Death(Time time, Kill cause)
        {
            Time = time;
            Cause = cause;
        }

        public Death()
        {
            
        }
    }
}