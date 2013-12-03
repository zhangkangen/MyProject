using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public class Student:Person,ISwim
    {

        public void Swim()
        {
            Console.WriteLine("学生会游泳");
        }
    }
}
