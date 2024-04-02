using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Child
    {
        private string _name;
        private Date _birthday;


        public Child(string name, Date birthday)
        {
                _name = name;
                _birthday = birthday;
        }


        public Date GetDateByAge(int age)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return _name + _birthday;


        }
    }
}
