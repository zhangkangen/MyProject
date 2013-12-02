using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02网页下载图片
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:8080/美女图片/美女们.htm";
            //能拿到的字符串 <img alt="" src="hotgirls/00_02.jpg" />

            //http://localhost:8080/美女图片/hotgirls/00_02.jpg
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            string reg = "<img alt=\"\" src=\"(hotgirls/((.+?)\\.jpg))\" />";
            MatchCollection mc = Regex.Matches(html, reg);
            foreach (Match item in mc)
            {
                string picUrl = Path.Combine("http://localhost:8080/美女图片", item.Groups[1].Value);
                string picName = item.Groups[2].Value;
                wc.DownloadFile(picUrl, picName);
            }
            Console.WriteLine("下载成功");
            Console.ReadKey();
        }
    }
}
