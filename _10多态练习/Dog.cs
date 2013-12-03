using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public class Dog : Animal,ISwim
    {
        public override void Bark()
        {
            Console.WriteLine("汪汪汪");
        }

        public void Swim()
        {
            Console.WriteLine("狗会游泳");
        }
    }
}
