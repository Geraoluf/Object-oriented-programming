using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class SchoolSystem
    {
        private YearDate _cutoff;
        public int _minAge { get; set; }
        public YearDate _schoolStart { get; set; }


        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;

        }


        public Date GetBeginning(Child schoolChild) 
        {
            Date oldEnough = schoolChild.GetDateByAge(_minAge);         
            Date cutoff = oldEnough.GetFirstOccurrence(_cutoff);        
            Date schoolday = cutoff.GetFirstOccurrence(_schoolStart);         
            return schoolday;
        }


    }
}
