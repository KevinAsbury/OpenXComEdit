using System;
using System.Collections.Generic;

namespace XComIIEdit.Lib
{
    public class Craft
    {
        public double lon { get; set; }
        public double lat { get; set; }
        public int id { get; set; }
        public double speedLon { get; set; }
        public double speedLat { get; set; }
        public double speedRadian { get; set; }
        public int speed { get; set; }
        public string type { get; set; }
        public int fuel { get; set; }
        public int damage { get; set; }
        public Dictionary<String, int> items { get; set; }
        public string status { get; set; }

        public Craft(double lon, double lat, int id, double speedLon, double speedLat, double speedRadian, int speed, string type, int fuel, int damage, Dictionary<string, int> items, string status)
        {
            this.lon = lon;
            this.lat = lat;
            this.id = id;
            this.speedLon = speedLon;
            this.speedLat = speedLat;
            this.speedRadian = speedRadian;
            this.speed = speed;
            this.type = type;
            this.fuel = fuel;
            this.damage = damage;
            this.items = items;
            this.status = status;
        }

        public Craft()
        {
            lon = 0.0;
            lat = 0.0;
            id = 0;
            speedLon = 0.0;
            speedLat = 0.0;
            speedRadian = 0.0;
            speed = 0;
            type = "";
            fuel = 0;
            damage = 0;
            items = new Dictionary<string, int>();
            status = "";
        }
    }
}