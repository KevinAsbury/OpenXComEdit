using System;
using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Craft
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public int Id { get; set; }
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

        public Craft(double lon, double lat, int id, double speedLon, double speedLat, double speedRadian, int speed, string type, int fuel, int damage, List<Weapon>? weapons, Dictionary<string, int> items, string status)
        {
            Lon = lon;
            Lat = lat;
            Id = id;
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
        }

        public Craft(double lat, double lon, int id, string type, int fuel, Dictionary<string, int> items, List<Weapon> weapons = null)
        {
            Lon = lon;
            Lat = lat;
            Id = id;
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
        }
    }
}