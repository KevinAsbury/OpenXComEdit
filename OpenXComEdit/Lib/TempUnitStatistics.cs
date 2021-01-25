using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class TempUnitStatistics
    {
        public bool WasUnconcious { get; set; }
        public List<Kill> Kills { get; set; }
        public int ShotAtCounter { get; set; }
        public int ShotsFiredCounter { get; set; }
        public int ShotsLandedCounter { get; set; }
        public int? HitCounter { get; set; }

        public TempUnitStatistics(bool wasUnconcious, List<Kill> kills, int shotAtCounter, int shotsFiredCounter, int shotsLandedCounter, int? hitCounter)
        {
            WasUnconcious = wasUnconcious;
            Kills = kills;
            ShotAtCounter = shotAtCounter;
            ShotsFiredCounter = shotsFiredCounter;
            ShotsLandedCounter = shotsLandedCounter;
            HitCounter = hitCounter;
        }

        public TempUnitStatistics()
        {
            WasUnconcious = false;
            Kills = new List<Kill>();
            ShotAtCounter = 0;
            ShotsFiredCounter = 0;
            ShotsLandedCounter = 0;
            HitCounter = null;
        }
    }
}