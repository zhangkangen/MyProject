using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public abstract class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _age;

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
