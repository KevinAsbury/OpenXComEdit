using System.Collections.Generic;
using SixLabors.ImageSharp;

namespace OpenXComEdit.Lib.GameAssets
{
    public class PCKReader
    {
        private byte[] buffer { get; set; }
        private List<int> offsets { get; set; }
        public List<Image> Images { get; set; }

        public PCKReader(string filename, bool ufo = true)
        {
            
        }

        
    }
}