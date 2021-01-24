using System.Collections.Generic;

namespace XComIIEdit.Lib
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
            hours = 0;
            Soldier = new Soldier();
        }
    }
}