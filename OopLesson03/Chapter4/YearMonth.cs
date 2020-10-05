using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    //演習4
    //4.1.1
    class YearMonth
    {
        public int Year { get; private set; }
        public int  Month { get; private set; }
        public YearMonth(int year, int month){
            Year = year;
            Month = month;
        }

        //4.1.2
        public bool Is21Century{
            get{
                return 2001 <= Year && Year <= 2100;
            }
        }

        //4.1.3
        public YearMonth AddOneMonth(){
            if (Month == 12)
                return new YearMonth(Year + 1, 1);
            else
                return new YearMonth(Year, Month + 1);
        }

        //4.1.4
        public override string ToString(){
            return $"{Year}年{Month}月";
        }
    }
}
