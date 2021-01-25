namespace OpenXComEdit.Lib
{
    public class MissionSite
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Deployment { get; set; }
        public int Texture { get; set; }
        public string Race { get; set; }
        public bool InBattlescape { get; set; }
        public bool Detected { get; set; }

        public MissionSite(double lon, double lat, int id, string type, string deployment, int texture, string race, bool inBattlescape, bool detected)
        {
            Lon = lon;
            Lat = lat;
            Id = id;
            Type = type;
            Deployment = deployment;
            Texture = texture;
            Race = race;
            InBattlescape = inBattlescape;
            Detected = detected;
        }

        public MissionSite()
        {
            
        }
    }
}