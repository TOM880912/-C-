using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接收收入内容
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////输入练习1
            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("上面输入姓名是：{0}", name);
            //Console.ReadKey();

            ////输入练习2：
            //Console.WriteLine("请问你喜欢吃什么水果?");
            //string fruit = Console.ReadLine();
            //Console.WriteLine("原来你喜欢吃{0},", fruit);
            //Console.ReadLine();

            //输入练习3：
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string age = Console.ReadLine();
            Console.WriteLine("请输入您的职业");
            string job = Console.ReadLine();
            Console.WriteLine("{0}的年龄是{1}，职业是{2}",name, age, job);
            Console.ReadKey();





        }
    }
}
