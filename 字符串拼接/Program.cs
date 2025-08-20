using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 10;
            int num3 = 30;
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",num1,num2,num3);
            //占位符使用是按照填坑的顺序输出。
            Console.WriteLine("第一个数字是{2}，第二个数字是{1}，第三个数字是{0}",num1,num2,num3);
            Console.ReadLine();







        }
    }
}
