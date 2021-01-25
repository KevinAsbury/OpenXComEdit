namespace OpenXComEdit.Lib
{
    public class Destination
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public Destination(double lat, double lon, string type, int id)
        {
            Lat = lat;
            Lon = lon;
            Type = type;
            Id = id;
        }

        public Destination()
        {
            Lat = 0;
            Lon = 0;
            Type = "";
            Id = 0;
        }
    }
}