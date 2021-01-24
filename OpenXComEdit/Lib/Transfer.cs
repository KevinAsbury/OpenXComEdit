using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Transfer
    {
        public int hours { get; set; }
        public Soldier Soldier { get; set; }

        public Transfer(int hours, Soldier soldier)
        {
            this.hours = hours;
            Soldier = soldier;
        }

        public Transfer()
        {
            
        }
    }
}