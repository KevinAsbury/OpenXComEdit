namespace XComIIEdit.Lib
{
    public class Region
    {
        public string Type { get; set; }
        public int ActivityXcom { get; set; }
        public int ActivityAlien { get; set; }

        public Region(string type, int activityXcom, int activityAlien)
        {
            Type = type;
            ActivityXcom = activityXcom;
            ActivityAlien = activityAlien;
        }

        public Region()
        {
            Type = "";
            ActivityXcom = 0;
            ActivityAlien = 0;
        }
    }
}