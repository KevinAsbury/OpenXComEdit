using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Item
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Owner { get; set; }
        public int PreviousOwner { get; set; }
        public string Inventoryslot { get; set; }
        public int InventoryX { get; set; }
        public int InventoryY { get; set; }
        public List<int> Position { get; set; }
        public bool? XCOMProperty { get; set; }
    }
}