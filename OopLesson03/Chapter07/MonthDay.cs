using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07{
    class MonthDay  {
        public int Day { get; private set; }
        public int Month { get; private set; }

        public MonthDay(int month, int day) {
            Month = month;
            Day = day;
        }

        //MonthDay同士の比較をする
        public override bool Equals(object obj)
        {
            var other = obj as MonthDay;
            if (other == null)
                throw new ArgumentException();
            return Day == other.Day && Month == other.Month;
        }

        //ハッシュコードを求める
        public override int GetHashCode()
        {
            var code = Month.GetHashCode();
            return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
}
