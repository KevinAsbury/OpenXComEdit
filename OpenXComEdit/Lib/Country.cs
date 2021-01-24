using System;

namespace XComIIEdit.Lib
{
    public class Country
    {
        public string Type { get; set; }
        public int Funding { get; set; } 
        public int ActivityXcom { get; set; }
        public int ActivityAlien { get; set; }

        public Country(string type, int funding, int activityXcom, int activityAlien)
        {
            Type = type;
            Funding = funding;
            ActivityXcom = activityXcom;
            ActivityAlien = activityAlien;
        }

        public Country()
        {
            Type = "";
            Funding = 0;
            ActivityXcom = 0;
            ActivityAlien = 0;
        }
    }
}