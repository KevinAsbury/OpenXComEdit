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
        public int? Ammoqty { get; set; }
        public int? AmmoItem { get; set; }
        public int? Unit { get; set; }

        public Item(int id, string type, int owner, int previousOwner, string inventoryslot, int inventoryX, int inventoryY, List<int> position, bool? xcomProperty, int? ammoqty, int? ammoItem, int? unit)
        {
            Id = id;
            Type = type;
            Owner = owner;
            PreviousOwner = previousOwner;
            Inventoryslot = inventoryslot;
            InventoryX = inventoryX;
            InventoryY = inventoryY;
            Position = position;
            XCOMProperty = xcomProperty;
            Ammoqty = ammoqty;
            AmmoItem = ammoItem;
            Unit = unit;
        }

        public Item()
        {
            Id = 0;
            Type = "";
            Owner = 0;
            PreviousOwner = 0;
            Inventoryslot = "";
            InventoryX = 0;
            InventoryY = 0;
            Position = new List<int>();
            XCOMProperty = null;
            Ammoqty = null;
            AmmoItem = null;
            Unit = null;
        }
    }
}