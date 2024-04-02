using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class YearDate
    {
        private int _month;
        private int _day;



        public YearDate(int month, int day)
        {
           _month = month;
            _day = day;
        }


        public override string ToString()
        {
            return $"{_month:D2}/{_day:D2}";
        }

    }
}
