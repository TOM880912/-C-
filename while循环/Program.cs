using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////while循环案例1
            //int n = 10;
            //while (n > 0)
            //{
            //    Console.WriteLine("学习C#一定要坚持，不断学习，不断进步！");  //循环体。
            //    n--;//循环一次减1.
            //}
            //Console.ReadKey();


            ////while循环求1-100之间整数的和
            ////循环体：加数字，并且让数字加1
            //int sum = 0;
            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;


            //}
            //Console.WriteLine("1-100之间整数的和为：" + sum);
            //Console.ReadKey();

            ////while循环案例2：求1到100之间偶数的和
            //int sum = 0;
            //int i = 2;
            //while (i <= 100)
            //{
            //    sum += i;
            //    i += 2;
            //}
            //Console.WriteLine("1到100之间偶数的和为：" + sum);
            //Console.ReadKey();


            ////while循环案例3：while循环的嵌套
            //int i = 0;
            //int j = 0;
            //while (i < 10)
            //{
            //    while (j < 10)
            //    {
            //        Console.WriteLine("内部循环");
            //        j++;
            //        break;
            //    }
            //    j = 0;
            //    i++;
            //    Console.WriteLine("\t外部循环\t");
            //}
            //Console.ReadKey();

            ////while循环案例4：计算班级的平均成绩和总成绩；
            ////循环体：输入学生的成绩，并求和，
            //// 循环条件： 班级人数
            //Console.WriteLine("请输入班级的人数：");
            //int numStudents = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //int sum = 0;
            //double average = 0;
            //while (numStudents >= i)
            //{

            //    Console.WriteLine("请输入第{0}个学生的成绩:", i);
            //    sum += Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}
            //average = (double)sum / numStudents;
            //Console.WriteLine("班级的平均成绩为：" + average);
            //Console.WriteLine("班级的总成绩为：" + sum);
            //Console.ReadKey();


            //while循环案例5：教学，有次数限制，循环次数不能超过10次。
            //循环体：老师教学生，并问学生是否学会,自增
            //循环条件：1.学生是否学会，2.次数是否到达10次。

            string input = "";
            int i = 1;
            while (input != "Y"&& i < 10)
            {
                Console.WriteLine("老师第{0}遍教学", i);
                Console.WriteLine("你学会了吗？Y/N");
                input = Console.ReadLine();
                if (input=="Y")
                {
                    Console.WriteLine("总算是学会了，");
                    break;
                }
                i++;


            }
           
            Console.ReadKey();



            ////2006年，学员8000万人，每年25%增长，到那一年，累计人数为20万人。
            ////循环体：1.自增，2.计算累计培养学生的人数。
            ////循环条件：累计人数是否到达20万。
            //int Year = 2006;
            //double num = 0;
            //double numStudents = 8000;
            //while (num < 200000)
            //{

            //    num += numStudents;
            //    numStudents*= 1.25;
            //    if (num >= 200000)
            //    {
            //        break;
            //    }
            //    Year++;
            //}
            //Console.WriteLine("截至到{0}年，累计培养学生达到{1:0}人。",Year,num);
            //Console.ReadKey();


            // //while循环案例6：登录输入密码，输入错误三次后锁定账户。
            // //循环体：提示输入密码，判断是否正确，正确跳出循环，错误继续循环，while加if。
            // //循环条件：判断输入次数是否超过三次。
            // string username
            //string password
            // int i = 0;
            // while (i < 3)
            // {
            //     Console.WriteLine("请输入用户名：");
            //      username = Console.ReadLine();
            //     Console.WriteLine("请输入密码：");
            //     password = Console.ReadLine();
            //     if (username == "admin" && password == "12345678")
            //     {
            //         Console.WriteLine("登录成功！");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("密码错误，请重新输入！");
            //     }
            //     i++;
            // }
            // if (i == 3)
            // {
            //     Console.WriteLine("登录失败账号锁定");
            // }
            // Console.ReadKey();












        }
    }
}
