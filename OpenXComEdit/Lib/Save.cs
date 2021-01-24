using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
        public List<int> Funds { get; set; }
        public List<int> Maintenance { get; set; }
        public List<int> ResearchScores { get; set; }
        public List<int> Incomes { get; set; }
        public List<int> Expenditures { get; set; }
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

        public Save(string name, string version, string build, Time time, List<string> mods, int difficulty, int end, int monthsPassed, string graphRegionToggles, string graphCountryToggles, string graphFinanceToggles, ulong rng, List<int> funds, List<int> maintenance, List<int> researchScores, List<int> incomes, List<int> expenditures, bool warned, double globeLon, double globeLat, int globeZoom, Dictionary<string, int> ids, List<Country> countries, List<Region> regions, List<Base> bases, List<AlienMission> alienMissions, AlienStrategy alienStrategy, List<Soldier>? deadSoldiers, List<MissionStatistics>? missionStatistics)
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
            DefaultInitializer();
            Name = name;
        }

        public Save()
        {
            DefaultInitializer();
        }

        private void DefaultInitializer()
        {
            Name = "Start";
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
            Funds = new List<int>();
            Funds.Add(4132000);
            Maintenance = new List<int>();
            Maintenance.Add(0);
            ResearchScores = new List<int>();
            ResearchScores.Add(0);
            Incomes = new List<int>();
            Incomes.Add(6001000);
            Expenditures = new List<int>();
            Expenditures.Add(1869000);
            Warned = false;
            GlobeLon = 4.4710698541533835;
            GlobeLat = -0.78844019487154438;
            GlobeZoom = 0;
            Ids = new Dictionary<string, int>();
            Ids.Add("ALIEN_MISSIONS", 3);
            Ids.Add("STR_INTERCEPTOR", 3);
            Ids.Add("STR_SKYRANGER", 2);
            Ids.Add("STR_SOLDIER", 9);
            Countries = defaultCountries();
            Regions = DefaultRegions();
            Bases = new List<Base>();
            AlienMissions = StartingAlienMissions();
            AlienStrategy = new AlienStrategy();
            DeadSoldiers = null;
            MissionStatistics = null;
        }

        private List<Country> defaultCountries()
        {
            var result = new List<Country>();

            var countries = new Dictionary<string, int>();
            countries.Add("STR_USA", 839000);
            countries.Add("STR_RUSSIA", 272000);
            countries.Add("STR_UK", 350000);
            countries.Add("STR_FRANCE", 558000);
            countries.Add("STR_GERMANY", 287000);
            countries.Add("STR_ITALY", 252000);
            countries.Add("STR_SPAIN", 177000);
            countries.Add("STR_CHINA", 412000);
            countries.Add("STR_JAPAN", 666000);
            countries.Add("STR_INDIA", 223000);
            countries.Add("STR_BRAZIL", 414000);
            countries.Add("STR_AUSTRALIA", 356000);
            countries.Add("STR_NIGERIA", 182000);
            countries.Add("STR_SOUTH_AFRICA", 417000);
            countries.Add("STR_EGYPT", 303000);
            countries.Add("STR_CANADA", 293000);

            foreach (var country in countries)
            {
                var name = country.Key;

                var funding = new List<int>();
                funding.Add(country.Value);

                var xcomActivity = new List<int>();
                xcomActivity.Add(0);

                var alienActivity = new List<int>();
                alienActivity.Add(0);

                var ca = new Country(name, funding, xcomActivity, alienActivity);
                result.Add(ca);
            }

            return result;
        }

        private List<Region> DefaultRegions()
        {
            var result = new List<Region>();
            var regions = new List<string>();
            regions.Add("STR_NORTH_AMERICA");
            regions.Add("STR_ARCTIC");
            regions.Add("STR_ANTARCTICA");
            regions.Add("STR_SOUTH_AMERICA");
            regions.Add("STR_EUROPE");
            regions.Add("STR_NORTH_AFRICA");
            regions.Add("STR_SOUTHERN_AFRICA");
            regions.Add("STR_CENTRAL_ASIA");
            regions.Add("STR_SOUTH_EAST_ASIA");
            regions.Add("STR_SIBERIA");
            regions.Add("STR_AUSTRALASIA");
            regions.Add("STR_PACIFIC");
            regions.Add("STR_NORTH_ATLANTIC");
            regions.Add("STR_SOUTH_ATLANTIC");
            regions.Add("STR_INDIAN_OCEAN");

            foreach (var region in regions)
            {
                result.Add(new Region(region));
            }

            return result;
        }

        private List<AlienMission> StartingAlienMissions()
        {
            var result = new List<AlienMission>();

            var mission1 = new AlienMission(
                "STR_ALIEN_RESEARCH",
                "STR_NORTH_AMERICA",
                "STR_SECTOID",
                0,
                0,
                120,
                0,
                1,
                -1);

            result.Add(mission1);

            var mission2 = new AlienMission(
                "STR_ALIEN_TERROR",
                "STR_NORTH_AFRICA",
                "STR_FLOATER",
                0,
                0,
                150,
                0,
                2,
                1);

            result.Add(mission2);

            return result;
        }
    }
}
