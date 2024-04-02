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


        public Date GetBeginning(Child schoolChild) //(Child=fødselsdsag, navn)
        {
            Date oldEnough = schoolChild.GetDateByAge(_minAge);
            //udregning af om barnet er gammel nok vil være Child ansvar
            //er barnet gammel nok til at begynde skolen.
            //GetDateByAge modtager (_minAge) til sin udregning og retunere 
            //noget tilbage. OOP. (opdeling af ansvar)

            Date cutoff = oldEnough.GetFirstOccurrence(_cutoff);
            //udregning af cutoffdate vil være Date ansvar
            //når barnet er gammel nok fx 6 år hvad er første valide cutoff dato

            Date schoolday = cutoff.GetFirstOccurrence(_schoolStart);
            //først mulige lejlighed af skolebeginning dato på selve cutoff
            //dato eller efter cutoff

            return schoolday;

            //Responsebility in OOP
            //collaboration til at nå opfyldelse af usecase


        }


    }
}
