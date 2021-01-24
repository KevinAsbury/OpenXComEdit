namespace XComIIEdit.Lib
{
    public class Research
    {
        public string Project { get; set; }
        public int Assigned { get; set; }
        public int Spent { get; set; }
        public int Cost { get; set; }

        public Research(string project, int assigned, int spent, int cost)
        {
            Project = project;
            Assigned = assigned;
            Spent = spent;
            Cost = cost;
        }

        public Research()
        {
            Project = "";
            Assigned = 0;
            Spent = 0;
            Cost = 0;
        }
    }
}