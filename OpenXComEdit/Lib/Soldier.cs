using System.Collections.Generic;

namespace XComIIEdit.Lib
{
    public class Soldier
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Stats InitialStats { get; set; }
        public Stats CurrentStats { get; set; }
        public int Rank { get; set; }
        public SoldierCraft Craft { get; set; }
        public int Gender { get; set; }
        public int Look { get; set; }
        public int Missions { get; set; }
        public int Kills { get; set; }
        public int? Recovery { get; set; }
        public Diary Diary { get; set; }
        public string Armor { get; set; }
        public int Improvement { get; set; }
        public int PsiStrImprovement { get; set; }
        public List<ItemType>? EquipmentSlot { get; set; }
        public Death? Death { get; set; }

        public Soldier(string type, int id, string name, Stats initialStats, Stats currentStats, int rank, SoldierCraft craft, int gender, int look, int missions, int kills, int? recovery, Diary diary, string armor, int improvement, int psiStrImprovement, List<ItemType>? equipmentSlot, Death? death)
        {
            Type = type;
            Id = id;
            Name = name;
            InitialStats = initialStats;
            CurrentStats = currentStats;
            Rank = rank;
            Craft = craft;
            Gender = gender;
            Look = look;
            Missions = missions;
            Kills = kills;
            Recovery = recovery;
            Diary = diary;
            Armor = armor;
            Improvement = improvement;
            PsiStrImprovement = psiStrImprovement;
            EquipmentSlot = equipmentSlot;
            Death = death;
        }

        public Soldier()
        {
            Type = "";
            Id = 0;
            Name = "";
            InitialStats = new Stats();
            CurrentStats = new Stats();
            Rank = 0;
            Craft = new SoldierCraft();
            Gender = 0;
            Look = 0;
            Missions = 0;
            Kills = 0;
            Recovery = null;
            Diary = new Diary();
            Armor = "";
            Improvement = 0;
            PsiStrImprovement = 0;
            EquipmentSlot = null;
            Death = null;
        }
    }
}