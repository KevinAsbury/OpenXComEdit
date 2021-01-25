using System;
using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Craft
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public double SpeedLon { get; set; }
        public double SpeedLat { get; set; }
        public double SpeedRadian { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int Fuel { get; set; }
        public int Damage { get; set; }
        public List<Weapon>? Weapons { get; set; }
        public Dictionary<String, int> Items { get; set; }
        public string Status { get; set; }
        public Destination? Dest { get; set; }
        public bool? InBattlescape { get; set; }

        public Craft(double lon, double lat, int id, string? name, double speedLon, double speedLat, double speedRadian, int speed, string type, int fuel, int damage, List<Weapon>? weapons, Dictionary<string, int> items, string status, Destination? dest, bool? inBattlescape)
        {
            Lon = lon;
            Lat = lat;
            Id = id;
            Name = name;
            SpeedLon = speedLon;
            SpeedLat = speedLat;
            SpeedRadian = speedRadian;
            Speed = speed;
            Type = type;
            Fuel = fuel;
            Damage = damage;
            Weapons = weapons;
            Items = items;
            Status = status;
            Dest = dest;
            InBattlescape = inBattlescape;
        }

        public Craft(double lat, double lon, int id, string type, int fuel, Dictionary<string, int> items, List<Weapon> weapons = null)
        {
            Lon = lon;
            Lat = lat;
            Id = id;
            Name = null;
            SpeedLon = 0;
            SpeedLat = 0;
            SpeedRadian = 0;
            Speed = 0;
            Type = type;
            Fuel = fuel;
            Damage = 0;
            Weapons = weapons;
            Items = items;
            Status = "STR_READY";
            Dest = null;
            InBattlescape = null;
        }

        public Craft()
        {
            
        }
    }
}