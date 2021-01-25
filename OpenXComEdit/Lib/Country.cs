using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Country
    {
        public string Type { get; set; }
        public List<int> Funding { get; set; }
        public List<int> ActivityXcom { get; set; }
        public List<int> ActivityAlien { get; set; }

        public Country(string type, List<int> funding, List<int> activityXcom, List<int> activityAlien)
        {
            Type = type;
            Funding = funding;
            ActivityXcom = activityXcom;
            ActivityAlien = activityAlien;
        }

        public Country()
        {
            Type = "";
            Funding = new List<int>();
            Funding.Add(0);
            ActivityXcom = new List<int>();
            ActivityXcom.Add(0);
            ActivityAlien = new List<int>();
            ActivityAlien.Add(0);
        }
    }
}