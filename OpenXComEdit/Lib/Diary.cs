using System.Collections.Generic;

namespace OpenXComEdit.Lib
{
    public class Diary
    {
        public List<KillList>? KillList { get; set; }
        public List<int>? MissionIdList { get; set; }
        public int? DaysWoundedTotal { get; set; }
        public int? MonthsService { get; set; }
        public int? UnconciousTotal { get; set; }
        public int? ShotAtCounterTotal { get; set; }
        public int? HitCounterTotal { get; set; }
        public int? TotalShotFriendlyCounter { get; set; }
        public int? ShotsFiredCounterTotal { get; set; }
        public int? ShotsLandedCounterTotal { get; set; }
        public int? TimesWoundedTotal { get; set; }
        public int? StatGainTotal { get; set; }
        public int? BestOfRank { get; set; }
        public int? BestSoldier { get; set; }
        public int? TotalShotByFriendlyCounter { get; set; }

        public Diary(List<KillList>? killList, List<int>? missionIdList, int? daysWoundedTotal, int? monthsService, int? unconciousTotal, int? shotAtCounterTotal, int? hitCounterTotal, int? totalShotFriendlyCounter, int? shotsFiredCounterTotal, int? shotsLandedCounterTotal, int? timesWoundedTotal, int? statGainTotal, int? bestOfRank, int? bestSoldier, int? totalShotByFriendlyCounter)
        {
            KillList = killList;
            MissionIdList = missionIdList;
            DaysWoundedTotal = daysWoundedTotal;
            MonthsService = monthsService;
            UnconciousTotal = unconciousTotal;
            ShotAtCounterTotal = shotAtCounterTotal;
            HitCounterTotal = hitCounterTotal;
            TotalShotFriendlyCounter = totalShotFriendlyCounter;
            ShotsFiredCounterTotal = shotsFiredCounterTotal;
            ShotsLandedCounterTotal = shotsLandedCounterTotal;
            TimesWoundedTotal = timesWoundedTotal;
            StatGainTotal = statGainTotal;
            BestOfRank = bestOfRank;
            BestSoldier = bestSoldier;
            TotalShotByFriendlyCounter = totalShotByFriendlyCounter;
        }

        public Diary()
        {
            KillList = null;
            MissionIdList = null;
            DaysWoundedTotal = null;
            MonthsService = null;
            UnconciousTotal = null;
            ShotAtCounterTotal = null;
            HitCounterTotal = null;
            TotalShotFriendlyCounter = null;
            ShotsFiredCounterTotal = null;
            ShotsLandedCounterTotal = null;
            TimesWoundedTotal = null;
            StatGainTotal = null;
            BestOfRank = null;
            BestSoldier = null;
            TotalShotByFriendlyCounter = null;
        }
    }
}