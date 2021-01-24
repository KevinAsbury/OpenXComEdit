using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class PossibleMission
    {
        public string Region { get; set; }
        public Dictionary<string, int>? Missions { get; set; }

        public PossibleMission(string region, Dictionary<string, int> missions)
        {
            Region = region;
            Missions = missions;
        }

        public PossibleMission()
        {
            Region = "";
            Missions = new Dictionary<string, int>();
        }
    }
}