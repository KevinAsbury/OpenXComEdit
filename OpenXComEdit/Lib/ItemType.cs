namespace OpenXComEdit.Lib
{
    public class ItemType
    {
        public string Slot { get; set; }
        public string AmmoItem { get; set; }
        public string? SlotX { get; set; }
        public string? SlotY { get; set; }

        public ItemType(string slot, string ammoItem, string? slotX, string? slotY)
        {
            Slot = slot;
            AmmoItem = ammoItem;
            SlotX = slotX;
            SlotY = slotY;
        }

        public ItemType()
        {
            
        }
    }
}