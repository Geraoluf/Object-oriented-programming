using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Date
    {
        private int _year;
        private YearDate _day;

        public Date(int year, YearDate day)
        {
            _year = year;
            
            _day = day;
        }



        public Date GetFirstOccurrence(YearDate day)
        {
            throw new NotImplementedException();
        }



        public override string ToString()
        {
            return $"{_year} {_day}";
        }
    }
}
