using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class AI
    {
        public int FromNode { get; set; }
        public int ToNode { get; set; }
        public int AIMode { get; set; }
        public List<int> WasHitBy { get; set; }

        public AI(int fromNode, int toNode, int aiMode, List<int> wasHitBy)
        {
            FromNode = fromNode;
            ToNode = toNode;
            AIMode = aiMode;
            WasHitBy = wasHitBy;
        }

        public AI()
        {
            
        }
    }
}