namespace OpenXComEdit.Lib
{
    public class Weapon
    {
        public string Type { get; set; }
        public int Ammo { get; set; }
        public bool? Rearming { get; set; }

        public Weapon(string type, int ammo, bool? rearming = null)
        {
            Type = type;
            Ammo = ammo;
            Rearming = rearming;
        }

        public Weapon()
        {
            Type = "";
            Ammo = 0;
            Rearming = null;
        }
    }
}