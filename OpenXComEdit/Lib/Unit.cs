using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Unit
    {
        public int Id { get; set; }
        public string GenUnitType { get; set; }
        public string GenUnitArmor { get; set; }
        public int Faction { get; set; }
        public int Status { get; set; }
        public List<int> Position { get; set; }
        public int Direction { get; set; }
        public int DirectionTurret { get; set; }
        public int Tu { get; set; }
        public int Health { get; set; }
        public int Stunlevel { get; set; }
        public int Energy { get; set; }
        public int Morale { get; set; }
        public bool Kneeled { get; set; }
        public bool Floating { get; set; }
        public List<int> Armor { get; set; }
        public List<int> FatalWounds { get; set; }
        public int Fire { get; set; }
        public int ExpBravery { get; set; }
        public int ExpReactions { get; set; }
        public int ExpFiring { get; set; }
        public int ExpThrowing { get; set; }
        public int ExpPsiSkill { get; set; }
        public int ExpPsiStrength { get; set; }
        public int ExpMelee { get; set; }
        public int TurretType { get; set; }
        public bool Visible { get; set; }
        public int TurnsSinceSpotted { get; set; }
        public int RankInt { get; set; }
        public int MoraleRestored { get; set; }
        public AI? AI { get; set; }
        public int KilledBy { get; set; }
        public int Kills { get; set; }
        public int MotionPoints { get; set; }
        public bool Respawn { get; set; }
        public string ActiveHand { get; set; }
        public TempUnitStatistics TempUnitStatistics { get; set; }
        public int MurdererId { get; set; }
        public int FatalShotSide { get; set; }
        public int FatalShotBodyPart { get; set; }
        public string MurdererWeapon { get; set; }
        public string MurdererWeaponAmmo { get; set; }
        public List<List<int>> Recolor { get; set; }
        public int MindControllerID { get; set; }

        public Unit(int id, string genUnitType, string genUnitArmor, int faction, int status, List<int> position, int direction, int directionTurret, int tu, int health, int stunlevel, int energy, int morale, bool kneeled, bool floating, List<int> armor, List<int> fatalWounds, int fire, int expBravery, int expReactions, int expFiring, int expThrowing, int expPsiSkill, int expPsiStrength, int expMelee, int turretType, bool visible, int turnsSinceSpotted, int rankInt, int moraleRestored, AI? ai, int killedBy, int kills, int motionPoints, bool respawn, string activeHand, TempUnitStatistics tempUnitStatistics, int murdererId, int fatalShotSide, int fatalShotBodyPart, string murdererWeapon, string murdererWeaponAmmo, List<List<int>> recolor, int mindControllerId)
        {
            Id = id;
            GenUnitType = genUnitType;
            GenUnitArmor = genUnitArmor;
            Faction = faction;
            Status = status;
            Position = position;
            Direction = direction;
            DirectionTurret = directionTurret;
            Tu = tu;
            Health = health;
            Stunlevel = stunlevel;
            Energy = energy;
            Morale = morale;
            Kneeled = kneeled;
            Floating = floating;
            Armor = armor;
            FatalWounds = fatalWounds;
            Fire = fire;
            ExpBravery = expBravery;
            ExpReactions = expReactions;
            ExpFiring = expFiring;
            ExpThrowing = expThrowing;
            ExpPsiSkill = expPsiSkill;
            ExpPsiStrength = expPsiStrength;
            ExpMelee = expMelee;
            TurretType = turretType;
            Visible = visible;
            TurnsSinceSpotted = turnsSinceSpotted;
            RankInt = rankInt;
            MoraleRestored = moraleRestored;
            AI = ai;
            KilledBy = killedBy;
            Kills = kills;
            MotionPoints = motionPoints;
            Respawn = respawn;
            ActiveHand = activeHand;
            TempUnitStatistics = tempUnitStatistics;
            MurdererId = murdererId;
            FatalShotSide = fatalShotSide;
            FatalShotBodyPart = fatalShotBodyPart;
            MurdererWeapon = murdererWeapon;
            MurdererWeaponAmmo = murdererWeaponAmmo;
            Recolor = recolor;
            MindControllerID = mindControllerId;
        }

        public Unit()
        {
            Id = 0;
            GenUnitType = "";
            GenUnitArmor = "";
            Faction = 0;
            Status = 0;
            Position = new List<int>();
            Direction = 0;
            DirectionTurret = 0;
            Tu = 0;
            Health = 0;
            Stunlevel = 0;
            Energy = 0;
            Morale = 0;
            Kneeled = false;
            Floating = false;
            Armor = new List<int>();
            FatalWounds = new List<int>();
            Fire = 0;
            ExpBravery = 0;
            ExpReactions = 0;
            ExpFiring = 0;
            ExpThrowing = 0;
            ExpPsiSkill = 0;
            ExpPsiStrength = 0;
            ExpMelee = 0;
            TurretType = 0;
            Visible = false;
            TurnsSinceSpotted = 0;
            RankInt = 0;
            MoraleRestored = 0;
            AI = null;
            KilledBy = 0;
            Kills = 0;
            MotionPoints = 0;
            Respawn = false;
            ActiveHand = "";
            TempUnitStatistics = new TempUnitStatistics();
            MurdererId = 0;
            FatalShotSide = 0;
            FatalShotBodyPart = 0;
            MurdererWeapon = "";
            MurdererWeaponAmmo = "";
            Recolor = new List<List<int>>();
            MindControllerID = 0;
        }
    }
}