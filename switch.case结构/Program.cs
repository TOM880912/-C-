using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace @switch.case结构
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////张三年终评定switch case
            //bool b = true;
            //double salary = 5000;
            //Console.WriteLine("请输入张三的年终评定：");
            //string level = Console.ReadLine();
            //switch (level)
            //{ 
            //    case "A": salary+=1000;
            //        break;
            //    case "B": salary += 500;
            //        break;
            //    case "C":
            //        break;
            //    case "D":salary -= 500;
            //        break;
            //    case "E":salary -= 1000;
            //        break;
            //    default:Console.WriteLine("输入有误，请输入A-E中的一个");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("张三的年终奖金为：" + salary);
            //}
            //Console.ReadKey();


            ////switch case 练习2：上辈子的职业
            //bool b = true;
            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //string job = "";
            //switch (name)
            //{
            //    case "老赵":
            //        job = "程序员";
            //        break;
            //    case "老王":
            //        job = "猎人";
            //        break;
            //    case "老耿":
            //        job = "渣男";
            //        break;
            //    case "老张":
            //        job = "学渣";
            //        break;
            //    case "老刘":
            //        job = "科幻小说作家";
            //        break;
            //    default:
            //        Console.WriteLine("输入有误，请输入老赵-老刘中的一个");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("{0}在上辈子的职业是{1}", name, job);
            //}
            //Console.ReadKey();


            ////switch case 练习2：将区间问题转变为定值问题，通过除以10来将区间变成定值；
            //Console.WriteLine("请输入你的成绩");
            //int score = Convert.ToInt32(Console.ReadLine());

            //switch (score / 10)
            //{
            //    case 10:
            //    case 9:
            //        Console.WriteLine("你的等级是A");    //两个选项中的代码一样，可以简写。
            //        break;
            //    case 8:
            //        Console.WriteLine("你的等级是B");
            //        break;
            //    case 7:
            //        Console.WriteLine("你的等级是C");
            //        break;
            //    case 6:
            //        Console.WriteLine("你的等级是D");
            //        break;
            //    default:
            //        Console.WriteLine("你的等级是E");
            //        break;
            //}
            //Console.ReadKey();


            ////判断每月的天数
            //bool b = true;
            //int year = 0;
            //int month = 0;
            //int day = 0;
            //try
            //{
            //    Console.WriteLine("请输入年份");
            //    year = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入月份");
            //    month = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine(" 年份输入格式有误");
            //    b = false;
            //}
            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        day = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        day = 30;
            //        break;
            //    case 2:
            //        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            //        {
            //            day = 29;
            //        }
            //        else
            //        {
            //            day = 28;
            //        }
            //        break;
            //        default:
            //        Console.WriteLine("输入有误，月份请输入1-12中的一个数字");
            //        b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
            //}
            //Console.ReadKey();


            //判断每月天数，以最少代码执行量来写
            Console.WriteLine("请输入年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month <= 12 && month >= 1)
                    {
                        int day = 0;
                        if (month == 2)
                        {
                            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                            {
                                day = 29;
                            }
                            else
                            {
                                day = 28;
                            }
                        }
                        else if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            day = 30;
                        }
                        else
                        {
                            day = 31;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("月份输入值超出1-12月范围");
                    }
                    }//try月份呢
                catch   //catch月份。
                {
                    Console.WriteLine("月份输入格式无效");
                }
            }//try年份
            catch   //catch年份。
            {
                Console.WriteLine("年份输入格式无效");
            }
            Console.ReadKey();


        }
    }
}
