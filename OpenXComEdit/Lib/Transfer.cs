using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Transfer
    {
        public int hours { get; set; }
        public Soldier? Soldier { get; set; }
        public Craft? Craft { get; set; }
        public string? ItemId { get; set; }
        public int? ItemQty { get; set; }

        public Transfer(int hours, Soldier? soldier, Craft? craft, string? itemId, int? itemQty)
        {
            this.hours = hours;
            Soldier = soldier;
            Craft = craft;
            ItemId = itemId;
            ItemQty = itemQty;
        }

        public Transfer()
        {
            
        }
    }
}