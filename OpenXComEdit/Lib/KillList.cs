namespace XComIIEdit.Lib
{
    public class KillList
    {
        public string Type { get; set; }
        public string Rank { get; set; }
        public string Race { get; set; }
        public string Weapon { get; set; }
        public string WeaponAmmo { get; set; }
        public int Status { get; set; }
        public int Faction { get; set; }
        public int Mission { get; set; }
        public int Turn { get; set; }
        public int Side { get; set; }
        public int Bodypart { get; set; }
        public int Id { get; set; }

        public KillList(string type, string rank, string race, string weapon, string weaponAmmo, int status, int faction, int mission, int turn, int side, int bodypart, int id)
        {
            Type = type;
            Rank = rank;
            Race = race;
            Weapon = weapon;
            WeaponAmmo = weaponAmmo;
            Status = status;
            Faction = faction;
            Mission = mission;
            Turn = turn;
            Side = side;
            Bodypart = bodypart;
            Id = id;
        }

        public KillList()
        {
            Type = "";
            Rank = "";
            Race = "";
            Weapon = "";
            WeaponAmmo = "";
            Status = 0;
            Faction = 0;
            Mission = 0;
            Turn = 0;
            Side = 0;
            Bodypart = 0;
            Id = 0;
        }
    }
}