using System;
using System.CodeDom;
using System.Collections.Generic;

namespace XComIIEdit.Lib
{
    public class Base
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public string Name { get; set; }
        public List<Facility> Facilities { get; set; }
        public List<Soldier> Soldiers { get; set; }
        public List<Craft> Crafts { get; set; }
        public Dictionary<string, int> Items { get; set; }
        public int Scientists { get; set; }
        public int Engineers { get; set; }
        public List<Research>? Research { get; set; }
        public List<Transfer>? Transfers { get; set; }

        public Base(double lon, double lat, string name, List<Facility> facilities, List<Soldier> soldiers, List<Craft> crafts, Dictionary<string, int> items, int scientists, int engineers, List<Research> research)
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
        }

        public Base()
        {
            Lon = 0.0;
            Lat = 0.0;
            Name = "";
            Facilities = new List<Facility>();
            Soldiers = new List<Soldier>();
            Crafts = new List<Craft>();
            Items = new Dictionary<string, int>();
            Scientists = 0;
            Engineers = 0;
            Research = null;
        }
    }
}