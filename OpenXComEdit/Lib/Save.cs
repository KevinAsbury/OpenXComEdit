using System;
using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Save
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Build { get; set; }
        public Time Time { get; set; }
        public List<String> Mods { get; set; }
        public int Difficulty { get; set; }
        public int End { get; set; }
        public int MonthsPassed { get; set; }
        public string GraphRegionToggles { get; set; }
        public string GraphCountryToggles { get; set; }
        public string GraphFinanceToggles { get; set; }
        public ulong Rng { get; set; }
        public int Funds { get; set; }
        public int Maintenance { get; set; }
        public int ResearchScores { get; set; }
        public int Incomes { get; set; }
        public int Expenditures { get; set; }
        public bool Warned { get; set; }
        public double GlobeLon { get; set; }
        public double GlobeLat { get; set; }
        public int GlobeZoom { get; set; }
        public Dictionary<string, int> Ids { get; set; }
        public List<Country> Countries { get; set; }
        public List<Region> Regions { get; set; }
        public List<Base> Bases { get; set; }
        public List<AlienMission> AlienMissions { get; set; }
        public AlienStrategy AlienStrategy { get; set; }
        public List<Soldier>? DeadSoldiers { get; set; }
        public List<MissionStatistics>? MissionStatistics { get; set; }

        public Save(string name, string version, string build, Time time, List<string> mods, int difficulty, int end, int monthsPassed, string graphRegionToggles, string graphCountryToggles, string graphFinanceToggles, ulong rng, int funds, int maintenance, int researchScores, int incomes, int expenditures, bool warned, double globeLon, double globeLat, int globeZoom, Dictionary<string, int> ids, List<Country> countries, List<Region> regions, List<Base> bases, List<AlienMission> alienMissions, AlienStrategy alienStrategy, List<Soldier>? deadSoldiers, List<MissionStatistics>? missionStatistics)
        {
            Name = name;
            Version = version;
            Build = build;
            Time = time;
            Mods = mods;
            Difficulty = difficulty;
            End = end;
            MonthsPassed = monthsPassed;
            GraphRegionToggles = graphRegionToggles;
            GraphCountryToggles = graphCountryToggles;
            GraphFinanceToggles = graphFinanceToggles;
            Rng = rng;
            Funds = funds;
            Maintenance = maintenance;
            ResearchScores = researchScores;
            Incomes = incomes;
            Expenditures = expenditures;
            Warned = warned;
            GlobeLon = globeLon;
            GlobeLat = globeLat;
            GlobeZoom = globeZoom;
            Ids = ids;
            Countries = countries;
            Regions = regions;
            Bases = bases;
            AlienMissions = alienMissions;
            AlienStrategy = alienStrategy;
            DeadSoldiers = deadSoldiers;
            MissionStatistics = missionStatistics;
        }

        public Save(string name)
        {
            Name = name;
            Version = "1.0";
            Build = " git 2021-01-11 02:11";
            Time = new Time();
            Mods = new List<string>();
            Mods.Add("xcom1 ver: 1.0");
            Difficulty = 0;
            End = 0;
            MonthsPassed = 0;
            GraphRegionToggles = "";
            GraphCountryToggles = "";
            GraphFinanceToggles = "";
            Rng = Helper.LongRandom();
            Funds = 0;
            Maintenance = 0;
            ResearchScores = 0;
            Incomes = 0;
            Expenditures = 0;
            Warned = false;
            GlobeLon = 0.0;
            GlobeLat = 0.0;
            GlobeZoom = 0;
            Ids = new Dictionary<string, int>();
            Countries = new List<Country>();
            Regions = new List<Region>();
            Bases = new List<Base>();
            AlienMissions = new List<AlienMission>();
            AlienStrategy = null;
            MissionStatistics = null;
        }

        public Save()
        {
            Name = "";
            Version = "1.0";
            Build = " git 2021-01-11 02:11";
            Time = new Time();
            Mods = new List<string>();
            Mods.Add("xcom1 ver: 1.0");
            Difficulty = 0;
            End = 0;
            MonthsPassed = 0;
            GraphRegionToggles = "";
            GraphCountryToggles = "";
            GraphFinanceToggles = "";
            Rng = Helper.LongRandom();
            Funds = 0;
            Maintenance = 0;
            ResearchScores = 0;
            Incomes = 0;
            Expenditures = 0;
            Warned = false;
            GlobeLon = 0.0;
            GlobeLat = 0.0;
            GlobeZoom = 0;
            Ids = new Dictionary<string, int>();
            Countries = new List<Country>();
            Regions = new List<Region>();
            Bases = new List<Base>();
            AlienMissions = new List<AlienMission>();
            AlienStrategy = null;
            MissionStatistics = null;
        }
    }
}
