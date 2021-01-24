using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Region
    {
        public string Type { get; set; }
        public List<int> ActivityXcom { get; set; }
        public List<int> ActivityAlien { get; set; }

        public Region(string type, List<int> activityXcom, List<int> activityAlien)
        {
            Type = type;
            ActivityXcom = activityXcom;
            ActivityAlien = activityAlien;
        }

        public Region(string name)
        {
            Type = name;
            ActivityXcom = new List<int>();
            ActivityXcom.Add(0);
            ActivityAlien = new List<int>();
            ActivityAlien.Add(0);
        }

        public Region()
        {
            
        }
    }
}