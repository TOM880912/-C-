using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 关系逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////bool b = 1500 > 1;
            //bool b = 200 == 200;
            //Console.WriteLine(b);
            //Console.ReadLine();


            ////逻辑运算符案例1：
            //Console.WriteLine("请输入老赵的语文成绩：");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入老赵的数学成绩：");
            //int math = Convert.ToInt32(Console.ReadLine());
            //bool b1 = chinese > 90 && math > 90;
            //Console.WriteLine("老赵的语文和数学成绩都大于90是{0}",b1);
            //bool b2 = chinese > 90 || math > 90;
            //Console.WriteLine("老赵的语文和数学成绩有一门大于90是{0}", b2);
            //bool b3 = chinese < 60 && math < 60;
            //Console.WriteLine("老赵的语文和数学成绩都小于60是{0}", b3);
            //Console.ReadKey();


            //闰年的判断
            Console.WriteLine("请输入一个年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            Console.WriteLine("{0}年是闰年吗？{1}", year, isLeapYear);
            Console.ReadKey();


        }
    }
}
