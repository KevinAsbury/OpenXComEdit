using System.Collections.Generic;

namespace XComIIEdit.Lib
{
    public class MissionStatistics
    {
        public int Id { get; set; }
        public string MarkerName { get; set; }
        public int MarkerId { get; set; }
        public Time Time { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Ufo { get; set; }
        public bool Success { get; set; }
        public int Score { get; set; }
        public string Rating { get; set; }
        public string AlienRace { get; set; }
        public int Daylight { get; set; }
        public Dictionary<int, int> InjuryList { get; set; }
        public int LootValue { get; set; }

        public MissionStatistics(int id, string markerName, int markerId, Time time, string region, string country, string type, string ufo, bool success, int score, string rating, string alienRace, int daylight, Dictionary<int, int> injuryList, int lootValue)
        {
            Id = id;
            MarkerName = markerName;
            MarkerId = markerId;
            Time = time;
            Region = region;
            Country = country;
            Type = type;
            Ufo = ufo;
            Success = success;
            Score = score;
            Rating = rating;
            AlienRace = alienRace;
            Daylight = daylight;
            InjuryList = injuryList;
            LootValue = lootValue;
        }

        public MissionStatistics()
        {
            Id = 0;
            MarkerName = "";
            MarkerId = 0;
            Time = new Time();
            Region = "";
            Country = "";
            Type = "";
            Ufo = "";
            Success = false;
            Score = 0;
            Rating = "";
            AlienRace = "";
            Daylight = 0;
            InjuryList = new Dictionary<int, int>();
            LootValue = 0;
        }
    }
}