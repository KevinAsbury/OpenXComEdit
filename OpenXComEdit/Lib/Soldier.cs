using System;
using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Soldier
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Stats InitialStats { get; set; }
        public Stats CurrentStats { get; set; }
        public int Rank { get; set; }
        public SoldierCraft? Craft { get; set; }
        public int Gender { get; set; }
        public int Look { get; set; }
        public int Missions { get; set; }
        public int Kills { get; set; }
        public int? Recovery { get; set; }
        public Diary? Diary { get; set; }
        public string Armor { get; set; }
        public int Improvement { get; set; }
        public int PsiStrImprovement { get; set; }
        public List<Equipment>? EquipmentLayout { get; set; }
        public List<ItemType>? EquipmentSlot { get; set; }
        public Death? Death { get; set; }

        public Soldier(string type, int id, string name, Stats initialStats, Stats currentStats, int rank, SoldierCraft craft, int gender, int look, int missions, int kills, int? recovery, Diary? diary, string armor, int improvement, int psiStrImprovement, List<Equipment> equipmentLayout, List<ItemType>? equipmentSlot, Death? death)
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
            EquipmentLayout = equipmentLayout;
            EquipmentSlot = equipmentSlot;
            Death = death;
        }

        public Soldier(int id, string name, int gender, SoldierCraft? craft = null)
        {
            Type = "STR_SOLDIER";
            Id = id;
            Name = name;
            InitialStats = new Stats();
            CurrentStats = InitialStats;
            Rank = 0;
            Craft = craft;
            Gender = gender;
            Look = new Random().Next(0, 3);
            Missions = 0;
            Kills = 0;
            Recovery = null;
            Diary = null;
            Armor = "STR_NONE_UC";
            Improvement = 0;
            PsiStrImprovement = 0;
            EquipmentLayout = null;
            EquipmentSlot = null;
            Death = null;
        }

        public Soldier()
        {
            Type = "STR_SOLDIER";
            Id = 0;
            Name = "";
            InitialStats = new Stats();
            CurrentStats = InitialStats;
            Rank = 0;
            Craft = null;
            Gender = new Random().Next(0, 1); ;
            Look = new Random().Next(0, 3); ;
            Missions = 0;
            Kills = 0;
            Recovery = null;
            Diary = null;
            Armor = "";
            Improvement = 0;
            PsiStrImprovement = 0;
            EquipmentLayout = null;
            EquipmentSlot = null;
            Death = null;
        }

        public void SetCraft(double lat, double lon, string type, int id)
        {
            Craft = new SoldierCraft(lat, lon, type, id);
        }

        public void Edit(string name, int rank, int gender, int look, int? recovery, 
            int tu, int stamina, int health, int bravery, int reactions, int firing, 
            int throwing, int strength, int psiStrength, int psiSkill, int melee)
        {
            Name = name;
            Rank = rank;
            Gender = gender;
            Look = look;
            Recovery = recovery;
            CurrentStats.Tu = tu;
            CurrentStats.Stamina = stamina;
            CurrentStats.Health = health;
            CurrentStats.Bravery = bravery;
            CurrentStats.Reactions = reactions;
            CurrentStats.Firing = firing;
            CurrentStats.Throwing = throwing;
            CurrentStats.Strength = strength;
            CurrentStats.PsiStrength = psiStrength;
            CurrentStats.PsiSkill = psiSkill;
            CurrentStats.Melee = melee;
        }

        public void MaxAll()
        {
            Recovery = 0;
            CurrentStats.Tu = 81;
            CurrentStats.Stamina = 101;
            CurrentStats.Health = 61;
            CurrentStats.Bravery = 100;
            CurrentStats.Reactions = 105;
            CurrentStats.Firing = 125;
            CurrentStats.Throwing = 125;
            CurrentStats.Strength = 71;
            CurrentStats.PsiStrength = 100;
            CurrentStats.PsiSkill = 105;
            CurrentStats.Melee = 125;
        }
    }
}