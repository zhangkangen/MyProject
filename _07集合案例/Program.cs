using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07集合案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //有如下字符串：【“患者：“大夫，我咳嗽得很重。”  大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？””】。需求：①请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。②扩展（*）：统计出每个字符的出现次数(后面)
            string str = "患者：“大夫，我咳嗽得很重。”  大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            #region 求“咳嗽”两个字出现的次数
            //int index = 0;
            //string keyWord = "咳嗽";
            //int count = 0;//记录咳嗽出现的次数
            //while ((index = str.IndexOf(keyWord, index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现{1}的索引是{2}", count, keyWord, index);
            //    index += keyWord.Length;
            //}
            //Console.ReadKey();
            #endregion

            #region 判断每个字符出现的次数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                if (!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else
                {
                    dic[str[i]]++;
                }
            }
            foreach (KeyValuePair<char, int> item in dic)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
