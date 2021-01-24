using System.Collections.Generic;

namespace XComIIEdit.Lib
{
    public class AlienStrategy
    {
        public Dictionary<string, int> Regions { get; set; }
        public PossibleMission PossibleMissions { get; set; }
        public List<string> MissionLocations { get; set; }
        public List<string> MissionsRun { get; set; }

        public AlienStrategy(Dictionary<string, int> regions, PossibleMission possibleMissions, List<string> missionLocations, List<string> missionsRun)
        {
            Regions = regions;
            PossibleMissions = possibleMissions;
            MissionLocations = missionLocations;
            MissionsRun = missionsRun;
        }

        public AlienStrategy()
        {
            Regions = new Dictionary<string, int>();
            PossibleMissions = new PossibleMission();
            MissionLocations = new List<string>();
            MissionsRun = new List<string>();
        }
    }
}