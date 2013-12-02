using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_委托计算
{
    public delegate string CalDelegate(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string strNum1 = Console.ReadLine();
            Console.WriteLine("请输入运算符：");
            string ope = Console.ReadLine();
            Console.WriteLine("请输入第二个数字");
            string strNum2 = Console.ReadLine();
            string res = GetRes(strNum1, strNum2, ope);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static string GetRes(string strNum1, string strNum2, string ope)
        {
            string res = "";
            Calculator cal = new Calculator();
            switch (ope)
            {
                case "+": res = cal.Cal(int.Parse(strNum1), int.Parse(strNum2), Add);
                    break;
                case "-": res = cal.Cal(int.Parse(strNum1), int.Parse(strNum2), Sub);
                    break;
                case "*": res = cal.Cal(int.Parse(strNum1), int.Parse(strNum2), Mul);
                    break;
                case "/": res = cal.Cal(int.Parse(strNum1), int.Parse(strNum2), Div);
                    break;
            }
            return res;
        }
        /// <summary>
        /// 计算两个数的商
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private static string Div(int num1, int num2)
        {
            return (num1 / num2).ToString();
        }

        /// <summary>
        /// 计算两个数的乘积
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private static string Mul(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }


        /// <summary>
        /// 计算两个数的差
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private static string Sub(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        /// <summary>
        /// 计算两个数的和，并转换成字符串类型返回
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string Add(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
    }

}
