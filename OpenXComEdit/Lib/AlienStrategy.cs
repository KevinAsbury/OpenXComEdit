using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class AlienStrategy
    {
        public Dictionary<string, int> Regions { get; set; }
        public List<PossibleMission> PossibleMissions { get; set; }
        public Dictionary<string, int> MissionLocations { get; set; }
        public Dictionary<string, int> MissionsRun { get; set; }

        public AlienStrategy(Dictionary<string, int> regions, List<PossibleMission> possibleMissions, Dictionary<string, int> missionLocations, Dictionary<string, int> missionsRun)
        {
            Regions = regions;
            PossibleMissions = possibleMissions;
            MissionLocations = missionLocations;
            MissionsRun = missionsRun;
        }

        public AlienStrategy()
        {
            Regions = StartingRegions();
            PossibleMissions = StartingPossibleMissions();
            MissionLocations = new Dictionary<string, int>();
            MissionsRun = new Dictionary<string, int>();
        }

        private Dictionary<string, int> StartingRegions()
        {
            var result = new Dictionary<string, int>();

            result.Add("STR_ANTARCTICA", 4);
            result.Add("STR_ARCTIC", 4);
            result.Add("STR_AUSTRALASIA", 10);
            result.Add("STR_CENTRAL_ASIA", 12);
            result.Add("STR_EUROPE", 16);
            result.Add("STR_NORTH_AFRICA", 12);
            result.Add("STR_NORTH_AMERICA", 18);
            result.Add("STR_PACIFIC", 5);
            result.Add("STR_SIBERIA", 10);
            result.Add("STR_SOUTHERN_AFRICA", 8);
            result.Add("STR_SOUTH_AMERICA", 10);
            result.Add("STR_SOUTH_EAST_ASIA", 15);

            return result;
        }

        private List<PossibleMission> StartingPossibleMissions()
        {
            var result = new List<PossibleMission>();

            var mi0 = new Dictionary<string, int>();
            mi0.Add("STR_ALIEN_BASE", 35);
            mi0.Add("STR_ALIEN_RESEARCH", 25);
            var pm0 = new PossibleMission("STR_ANTARCTICA", mi0);
            result.Add(pm0);

            var mi1 = new Dictionary<string, int>();
            mi1.Add("STR_ALIEN_BASE", 35);
            mi1.Add("STR_ALIEN_RESEARCH", 25);
            var pm1 = new PossibleMission("STR_ARCTIC", mi1);
            result.Add(pm1);

            var mi2 = new Dictionary<string, int>();
            mi2.Add("STR_ALIEN_ABDUCTION", 4);
            mi2.Add("STR_ALIEN_BASE", 16);
            mi2.Add("STR_ALIEN_HARVEST", 11);
            mi2.Add("STR_ALIEN_INFILTRATION", 8);
            mi2.Add("STR_ALIEN_RESEARCH", 15);
            var pm2 = new PossibleMission("STR_AUSTRALASIA", mi2);
            result.Add(pm2);

            var mi3 = new Dictionary<string, int>();
            mi3.Add("STR_ALIEN_ABDUCTION", 6);
            mi3.Add("STR_ALIEN_BASE", 8);
            mi3.Add("STR_ALIEN_HARVEST", 5);
            mi3.Add("STR_ALIEN_INFILTRATION", 10);
            mi3.Add("STR_ALIEN_RESEARCH", 5);
            var pm3 = new PossibleMission("STR_CENTRAL_ASIA", mi3);
            result.Add(pm3);

            var mi4 = new Dictionary<string, int>();
            mi4.Add("STR_ALIEN_ABDUCTION", 15);
            mi4.Add("STR_ALIEN_BASE", 6);
            mi4.Add("STR_ALIEN_HARVEST", 10);
            mi4.Add("STR_ALIEN_INFILTRATION", 20);
            mi4.Add("STR_ALIEN_RESEARCH", 10);
            var pm4 = new PossibleMission("STR_EUROPE", mi4);
            result.Add(pm4);

            var pm5 = new PossibleMission("STR_INDIAN_OCEAN", null);
            result.Add(pm5);

            var mi6 = new Dictionary<string, int>();
            mi6.Add("STR_ALIEN_ABDUCTION", 8);
            mi6.Add("STR_ALIEN_BASE", 19);
            mi6.Add("STR_ALIEN_HARVEST", 8);
            mi6.Add("STR_ALIEN_INFILTRATION", 8);
            mi6.Add("STR_ALIEN_RESEARCH", 8);
            var pm6 = new PossibleMission("STR_NORTH_AFRICA", mi6);
            result.Add(pm6);

            var mi7 = new Dictionary<string, int>();
            mi7.Add("STR_ALIEN_ABDUCTION", 20);
            mi7.Add("STR_ALIEN_BASE", 20);
            mi7.Add("STR_ALIEN_HARVEST", 17);
            mi7.Add("STR_ALIEN_INFILTRATION", 20);
            var pm7 = new PossibleMission("STR_NORTH_AMERICA", mi7);
            result.Add(pm7);

            var pm8 = new PossibleMission("STR_NORTH_ATLANTIC", null);
            result.Add(pm8);

            var mi9 = new Dictionary<string, int>();
            mi9.Add("STR_ALIEN_BASE", 27);
            mi9.Add("STR_ALIEN_RESEARCH", 15);
            var pm9 = new PossibleMission("STR_PACIFIC", mi9);
            result.Add(pm9);

            var mi10 = new Dictionary<string, int>();
            mi10.Add("STR_ALIEN_ABDUCTION", 4);
            mi10.Add("STR_ALIEN_BASE", 9);
            mi10.Add("STR_ALIEN_RESEARCH", 6);
            var pm10 = new PossibleMission("STR_SIBERIA", mi10);
            result.Add(pm10);

            var mi11 = new Dictionary<string, int>();
            mi11.Add("STR_ALIEN_ABDUCTION", 9);
            mi11.Add("STR_ALIEN_BASE", 8);
            mi11.Add("STR_ALIEN_HARVEST", 8);
            mi11.Add("STR_ALIEN_INFILTRATION", 8);
            mi11.Add("STR_ALIEN_RESEARCH", 7);
            var pm11 = new PossibleMission("STR_SOUTHERN_AFRICA", mi11);
            result.Add(pm11);

            var mi12 = new Dictionary<string, int>();
            mi12.Add("STR_ALIEN_ABDUCTION", 12);
            mi12.Add("STR_ALIEN_BASE", 22);
            mi12.Add("STR_ALIEN_HARVEST", 24);
            mi12.Add("STR_ALIEN_INFILTRATION", 18);
            mi12.Add("STR_ALIEN_RESEARCH", 10);
            var pm12 = new PossibleMission("STR_SOUTH_AMERICA", mi12);
            result.Add(pm12);

            var pm13 = new PossibleMission("STR_SOUTH_ATLANTIC", null);
            result.Add(pm13);

            var mi14 = new Dictionary<string, int>();
            mi14.Add("STR_ALIEN_ABDUCTION", 21);
            mi14.Add("STR_ALIEN_BASE", 8);
            mi14.Add("STR_ALIEN_HARVEST", 13);
            mi14.Add("STR_ALIEN_INFILTRATION", 13);
            mi14.Add("STR_ALIEN_RESEARCH", 8);
            var pm14 = new PossibleMission("STR_SOUTH_EAST_ASIA", mi14);
            result.Add(pm14);

            return result;
        }
    }
}