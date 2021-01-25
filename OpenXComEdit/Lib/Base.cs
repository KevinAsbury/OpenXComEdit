using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Base
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public string Name { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<Soldier>? Soldiers { get; set; }
        public List<Craft>? Crafts { get; set; }
        public Dictionary<string, int> Items { get; set; }
        public int Scientists { get; set; }
        public int Engineers { get; set; }
        public List<Research>? Research { get; set; }
        public List<Transfer>? Transfers { get; set; }
        public List<Production>? Productions { get; set; }

        public Base(double lon, double lat, string name, List<Facility> facilities, List<Soldier> soldiers, List<Craft> crafts, Dictionary<string, int> items, int scientists, int engineers, List<Research>? research, List<Transfer>? transfers, List<Production>? productions)
        {
            Lon = lon;
            Lat = lat;
            Name = name;
            Facilities = facilities;
            Soldiers = soldiers;
            Crafts = crafts;
            Items = items;
            Scientists = scientists;
            Engineers = engineers;
            Research = research;
            Transfers = transfers;
            Productions = productions;
        }

        public Base(string name, double lon, double lat)
        {
            DefaultInitializer(name, lon, lat);
        }

        public Base(string name, double lon, double lat, int x, int y)
        {
            DefaultInitializer(name, lon, lat, x, y);
        }

        public Base()
        {
            DefaultInitializer("Base1", 4.5738924040249991, -0.86385638583468516, null, null);
        }

        private void DefaultInitializer(string name, double lon = 4.5738924040249991, double lat = -0.86385638583468516, int? x = null, int? y = null)
        {
            Lon = lon;
            Lat = lat;
            Name = name;

            if (x.HasValue && y.HasValue)
            {
                Facilities = LiftOnly(x.Value, y.Value);
                Items = new Dictionary<string, int>();
                Scientists = 0;
                Engineers = 0;
                Soldiers = null;
                Crafts = null;
            }
            else
            {
                Facilities = StartingFacilities();
                Items = StartingItems();
                Scientists = 10;
                Engineers = 10;
                Soldiers = StartingSoldiers();
                Crafts = StartingCrafts();
            }

            Research = null;
            Transfers = null;
            Productions = null;
        }

        private List<Facility> LiftOnly(int x, int y)
        {
            var result = new List<Facility>();
            result.Add(new Facility("STR_ACCESS_LIFT", x, y));
            return result;
        }

        private List<Facility> StartingFacilities()
        {
            var result = new List<Facility>();

            var access = new Facility("STR_ACCESS_LIFT", 2, 2);
            result.Add(access);
            var hang1 = new Facility("STR_HANGAR", 2, 0);
            result.Add(hang1);
            var hang2 = new Facility("STR_HANGAR", 0, 4);
            result.Add(hang2);
            var hang3 = new Facility("STR_HANGAR", 4, 4);
            result.Add(hang3);
            var lq = new Facility("STR_LIVING_QUARTERS", 3, 2);
            result.Add(lq);
            var gs = new Facility("STR_GENERAL_STORES", 2, 3);
            result.Add(gs);
            var lab = new Facility("STR_LABORATORY", 3, 3);
            result.Add(lab);
            var ws = new Facility("STR_WORKSHOP", 4, 3);
            result.Add(ws);
            var rad = new Facility("STR_SMALL_RADAR_SYSTEM", 1, 3);
            result.Add(rad);

            return result;
        }

        private Dictionary<string, int> StartingItems()
        {
            var result = new Dictionary<string, int>();
            result.Add("STR_AC_AP_AMMO", 6);
            result.Add("STR_AUTO_CANNON", 1);
            result.Add("STR_AVALANCHE_LAUNCHER", 1);
            result.Add("STR_AVALANCHE_MISSILES", 10);
            result.Add("STR_CANNON", 2);
            result.Add("STR_CANNON_ROUNDS_X50", 1);
            result.Add("STR_GRENADE", 5);
            result.Add("STR_HC_AP_AMMO", 6);
            result.Add("STR_HEAVY_CANNON", 1);
            result.Add("STR_PISTOL", 2);
            result.Add("STR_PISTOL_CLIP", 8);
            result.Add("STR_RIFLE", 2);
            result.Add("STR_RIFLE_CLIP", 8);
            result.Add("STR_ROCKET_LAUNCHER", 1);
            result.Add("STR_SMALL_ROCKET", 4);
            result.Add("STR_SMOKE_GRENADE", 5);
            result.Add("STR_STINGRAY_LAUNCHER", 1);
            result.Add("STR_STINGRAY_MISSILES", 25);
            return result;
        }

        private List<Soldier> StartingSoldiers()
        {
            var result = new List<Soldier>();

            var soldiers = new Dictionary<string, int>();
            soldiers.Add("Owen Doherty", 0);
            soldiers.Add("Martina Becker", 1);
            soldiers.Add("Willie de Haan", 0);
            soldiers.Add("Ushma Ganguly", 1);
            soldiers.Add("Okan Karaduman", 0);
            soldiers.Add("Sindre Folkow", 1);
            soldiers.Add("Nasir Asaf", 0);
            soldiers.Add("Lucian Marinescu", 0);

            var craft = new SoldierCraft(Lat, Lon, "STR_SKYRANGER", 1);

            int id = 1;
            foreach (var soldier in soldiers)
            {
                var xcSoldier = new Soldier(id++, soldier.Key, soldier.Value, craft);
                result.Add(xcSoldier);
            }

            return result;
        }

        private List<Craft> StartingCrafts()
        {
            var result = new List<Craft>();

            var sr1Items = new Dictionary<string, int>();
            sr1Items.Add("STR_GRENADE", 8);
            sr1Items.Add("STR_HC_AP_AMMO", 2);
            sr1Items.Add("STR_HC_HE_AMMO", 2);
            sr1Items.Add("STR_HEAVY_CANNON", 1);
            sr1Items.Add("STR_PISTOL", 3);
            sr1Items.Add("STR_PISTOL_CLIP", 5);
            sr1Items.Add("STR_RIFLE", 6);
            sr1Items.Add("STR_RIFLE_CLIP", 12);
            var sr1 = new Craft(Lat, Lon, 1, "STR_SKYRANGER", 1500, sr1Items);
            result.Add(sr1);

            var intercItems = new Dictionary<string, int>();
            var intWeaps = new List<Weapon>();
            intWeaps.Add(new Weapon("STR_STINGRAY", 6));
            intWeaps.Add(new Weapon("STR_CANNON_UC", 200));

            var interc1 = new Craft(Lat, Lon, 1, "STR_INTERCEPTOR", 1000, intercItems, intWeaps);
            result.Add(interc1);

            var interc2 = new Craft(Lat, Lon, 2, "STR_INTERCEPTOR", 1000, intercItems, intWeaps);
            result.Add(interc2);

            return result;
        }
    }
}