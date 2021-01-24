using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Diary
    {
        public KillList? KillList { get; set; }
        public List<int>? MissionIdList { get; set; }
        public int? DaysWoundedTotal { get; set; }
        public int? UnconciousTotal { get; set; }
        public int? ShotAtCounterTotal { get; set; }
        public int? HitCounterTotal { get; set; }
        public int? TotalShotFriendlyCounter { get; set; }
        public int? ShotsFiredCounterTotal { get; set; }
        public int? ShotsLandedCounterTotal { get; set; }
        public int? TimesWoundedTotal { get; set; }
        public int? statGainTotal { get; set; }

        public Diary(KillList? killList, List<int>? missionIdList, int? daysWoundedTotal, int? unconciousTotal, int? shotAtCounterTotal, int? hitCounterTotal, int? totalShotFriendlyCounter, int? shotsFiredCounterTotal, int? shotsLandedCounterTotal, int? timesWoundedTotal, int? statGainTotal)
        {
            KillList = killList;
            MissionIdList = missionIdList;
            DaysWoundedTotal = daysWoundedTotal;
            UnconciousTotal = unconciousTotal;
            ShotAtCounterTotal = shotAtCounterTotal;
            HitCounterTotal = hitCounterTotal;
            TotalShotFriendlyCounter = totalShotFriendlyCounter;
            ShotsFiredCounterTotal = shotsFiredCounterTotal;
            ShotsLandedCounterTotal = shotsLandedCounterTotal;
            TimesWoundedTotal = timesWoundedTotal;
            this.statGainTotal = statGainTotal;
        }

        public Diary()
        {
            KillList = null;
            MissionIdList = null;
            DaysWoundedTotal = null;
            UnconciousTotal = null;
            ShotAtCounterTotal = null;
            HitCounterTotal = null;
            TotalShotFriendlyCounter = null;
            ShotsFiredCounterTotal = null;
            ShotsLandedCounterTotal = null;
            TimesWoundedTotal = null;
            statGainTotal = null;
        }
    }
}