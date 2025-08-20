using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //转义字符换行
            Console.WriteLine("今天天气好晴朗\n处处好风光");
            Console.ReadKey();

            //英文半角符号输出
            Console.WriteLine("输出英文半角符号\"\"");
            Console.ReadKey();

            //转义字符排版,空格\t
            string name1 = "老赵";
            string name2 = "王阵";
            string name3 = "老赵牛逼";
            string name4 = "王阵学习";
            Console.WriteLine("{0}\t\t{1}", name1, name2);
            Console.WriteLine("{0}\t{1}", name3, name4);
            Console.ReadKey();

            //转义字符，退格键\b
            Console.WriteLine("飞流直下三千\b尺，疑是银河落九\b天");
            Console.ReadKey();

            //转义字符，@符号
            //@符号让路径文件中的\不产生作用,在前面家一个@符号。
            //@符号将字符串按照原格式输出。
            string path = @"C:\Users\Administrator\Desktop\1025.txt";
            Console.WriteLine(path);
            Console.WriteLine(@"明月几时有
            把酒问青天");
            Console.ReadKey();
        }
    }
}
