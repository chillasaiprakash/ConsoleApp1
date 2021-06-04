using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Person
    {
        private string _name;

        public void setName(string name)
        {
            this._name = name;
        }

        public string getName()
        {
            return _name;
        }
    }
}
