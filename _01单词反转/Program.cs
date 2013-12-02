using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单词反转
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一段英文");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                char[] chs = words[i].ToCharArray();
                for (int j = 0; j < chs.Length/2; j++)
                {
                    char temp = chs[j];
                    chs[j] = chs[chs.Length - 1 - j];
                    chs[chs.Length - 1 - j] = temp;
                }
                words[i] = new string(chs);
            }
            input = string.Join(" ", words);
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
}
