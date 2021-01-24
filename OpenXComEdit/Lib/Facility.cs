namespace OpenXComEdit.Lib
{
    public class Facility
    {
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? BuildTime { get; set; }

        public Facility(string type, int x, int y, int? buildTime = null)
        {
            Type = type;
            X = x;
            Y = y;
            BuildTime = buildTime;
        }

        public Facility()
        {
            Type = "";
            X = 0;
            Y = 0;
            BuildTime = null;
        }
    }
}