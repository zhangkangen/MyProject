using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _04序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 对象序列化
            //Person per = new Person("张三", 23, '男');
            //BinaryFormatter bf = new BinaryFormatter();
            //using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    bf.Serialize(fs, per);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey(); 
            #endregion
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("1.txt", FileMode.Open, FileAccess.Read))
            {
                object obj = bf.Deserialize(fs);
                Person per = (Person)obj;
                Console.WriteLine(per.Name);
                Console.WriteLine(per.Age);
                Console.WriteLine(per.Sex);
                
            }
            Console.ReadKey();
        }
    }
}
