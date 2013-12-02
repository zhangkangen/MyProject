using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_委托计算
{
    public class Calculator
    {
        /// <summary>
        /// 对两个数进行操作的类
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="cdl"></param>
        /// <returns></returns>
        public string Cal(int num1, int num2, CalDelegate cdl)
        {
            return cdl(num1, num2);
        }
    }
}
