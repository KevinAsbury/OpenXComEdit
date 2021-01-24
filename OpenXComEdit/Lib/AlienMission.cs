namespace OpenXComEdit.Lib
{
    public class AlienMission
    {
        public string Type { get; set; }
        public string Region { get; set; }
        public string Race { get; set; }
        public int NextWave { get; set; }
        public int NextUfoCounter { get; set; }
        public int SpawnCountdown { get; set; }
        public int LiveUfos { get; set; }
        public int UniqueID { get; set; }
        public int MissionSiteZone { get; set; }

        public AlienMission(string type, string region, string race, int nextWave, int nextUfoCounter, int spawnCountdown, int liveUfos, int uniqueId, int missionSiteZone)
        {
            Type = type;
            Region = region;
            Race = race;
            NextWave = nextWave;
            NextUfoCounter = nextUfoCounter;
            SpawnCountdown = spawnCountdown;
            LiveUfos = liveUfos;
            UniqueID = uniqueId;
            MissionSiteZone = missionSiteZone;
        }

        public AlienMission()
        {
            Type = "";
            Region = "";
            Race = "";
            NextWave = 0;
            NextUfoCounter = 0;
            SpawnCountdown = 0;
            LiveUfos = 0;
            UniqueID = 0;
            MissionSiteZone = 0;
        }
    }
}