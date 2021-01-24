namespace OpenXComEdit.Lib
{
    public class Facility
    {
        public string Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int? Building { get; set; }

        public Facility(string type, int x, int y, int? building = null)
        {
            Type = type;
            X = x;
            Y = y;
            Building = building;
        }

        public Facility()
        {
            Type = "";
            X = 0;
            Y = 0;
            Building = null;
        }
    }
}