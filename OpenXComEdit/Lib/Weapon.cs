namespace OpenXComEdit.Lib
{
    public class Weapon
    {
        public string Type { get; set; }
        public int Ammo { get; set; }

        public Weapon(string type, int ammo)
        {
            Type = type;
            Ammo = ammo;
        }
    }
}