namespace OpenXComEdit.Lib
{
    public class Equipment
    {
        public string ItemType { get; set; }
        public string Slot { get; set; }
        public int? SlotX { get; set; }
        public int? SlotY { get; set; }
        public string? AmmoItem { get; set; }

        public Equipment(string itemType, string slot, int? slotX, int? slotY, string? ammoItem)
        {
            ItemType = itemType;
            Slot = slot;
            SlotX = slotX;
            SlotY = slotY;
            AmmoItem = ammoItem;
        }

        public Equipment()
        {
            ItemType = "";
            Slot = "";
            SlotX = null;
            SlotY = null;
            AmmoItem = null;
        }
    }
}