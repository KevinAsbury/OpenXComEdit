namespace XComIIEdit.Lib
{
    public class Facility
    {
        public string Type { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public int? Building { get; set; }

        public Facility(string type, string x, string y, int? building)
        {
            Type = type;
            X = x;
            Y = y;
            Building = building;
        }

        public Facility()
        {
            Type = "";
            X = "";
            Y = "";
            Building = null;
        }
    }
}