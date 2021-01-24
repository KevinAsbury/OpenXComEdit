namespace OpenXComEdit.Lib
{
    public class SoldierCraft
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public SoldierCraft(double lat, double lon, string type, int id)
        {
            Lon = lon;
            Lat = lat;
            Type = type;
            Id = id;
        }

        public SoldierCraft()
        {
            Lon = 0.0;
            Lat = 0.0;
            Type = "";
            Id = 0;
        }
    }
}