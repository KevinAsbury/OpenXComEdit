namespace OpenXComEdit.Lib
{
    public class Death
    {
        public Time Time { get; set; }
        public KillList Cause { get; set; }

        public Death(Time time, KillList cause)
        {
            Time = time;
            Cause = cause;
        }

        public Death()
        {
            
        }
    }
}