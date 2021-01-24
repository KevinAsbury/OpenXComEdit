namespace OpenXComEdit.Lib
{
    public class Production
    {
        public string Item { get; set; } 
        public int Assigned { get; set; }
        public int Spent { get; set; }
        public int Amount { get; set; }
        public bool Infinite { get; set; }

        public Production(string item, int assigned, int spent, int amount, bool infinite)
        {
            Item = item;
            Assigned = assigned;
            Spent = spent;
            Amount = amount;
            Infinite = infinite;
        }

        public Production()
        {
            Item = "";
            Assigned = 0;
            Spent = 0;
            Amount = 0;
            Infinite = false;
        }
    }
}