using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Node
    {
        public int Id { get; set; }
        public List<int> Position { get; set; }
        public int Type { get; set; }
        public int Rank { get; set; }
        public int Flags { get; set; }
        public int Reserved { get; set; }
        public int Priority { get; set; }
        public bool Allocated { get; set; }
        public List<int> Links { get; set; }
        public bool Dummy { get; set; }

        public Node(int id, List<int> position, int type, int rank, int flags, int reserved, int priority, bool allocated, List<int> links, bool dummy)
        {
            Id = id;
            Position = position;
            Type = type;
            Rank = rank;
            Flags = flags;
            Reserved = reserved;
            Priority = priority;
            Allocated = allocated;
            Links = links;
            Dummy = dummy;
        }

        public Node()
        {
            Id = 0;
            Position = new List<int>();
            Type = 0;
            Rank = 0;
            Flags = 0;
            Reserved = 0;
            Priority = 0;
            Allocated = false;
            Links = new List<int>();
            Dummy = false;
        }
    }
}