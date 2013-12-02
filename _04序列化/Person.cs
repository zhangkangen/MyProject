using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04序列化
{
    [Serializable]//将Person类标记为可序列化的
    public class Person
    {
        public Person()
        {
        }
        public Person(string name, int age, char sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _sex;

        public char Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
    }
}
