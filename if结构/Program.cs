using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace if结构
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////if案例1
            //Console.WriteLine("请输入跪键盘的时间：");
            //int time = Convert.ToInt32(Console.ReadLine());
            //if (time >= 20)
            //{
            //    Console.WriteLine("不用做饭");
            //}
            //else我们好我们闲时间基本上创建多少钱啊项
            //{
            //    Console.WriteLine("做饭");
            //}
            //Console.ReadKey();

            ////if案例2:结婚年龄判断
            //Console.WriteLine("请输入您的年龄");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 22)
            //{
            //    Console.WriteLine("恭喜您可以结婚了！");
            //}
            //else 
            //{
            //    Console.WriteLine("未满22岁，不能结婚！");

            //}
            //Console.ReadKey();

            ////if案例3：成绩判断
            //Console.WriteLine("请输入老苏的语文成绩：");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入老苏的数学成绩：");
            //int math = Convert.ToInt32(Console.ReadLine());
            //bool b = (chinese > 90 && math > 80) || (chinese == 100 && math > 70);
            //if (b)
            //{
            //    Console.WriteLine("奖励老苏100元");
            //}
            //else
            //{
            //    Console.WriteLine("奖励一顿毒打");
            //}
            //Console.ReadKey();


            ////if案例4：多条件判断
            //Console.WriteLine("请输入成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("成绩优秀");
            //}
            //if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("成绩良好");
            //}
            //if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("成绩不好");
            //}
            //if (score >= 60 && score < 70)
            //{
            //    Console.WriteLine("成绩及格");
            //}
            //if (score < 60)
            //{
            //    Console.WriteLine("成绩不及格");
            //}
            //Console.ReadKey();

            ////if案例5：多条件判断
            //Console.WriteLine("请输入成绩：");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("成绩优秀");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("成绩良好");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("成绩不好");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("成绩及格");
            //}
            //else if (score < 60)
            //{
            //    Console.WriteLine("成绩不及格");
            //}
            //else
            //{
            //    Console.WriteLine("输入错误");
            //}
            //Console.ReadKey();


            ////if案例6: 三个数字大小判断,不考虑相等
            ////提示用户输入三个数字，并转换为int类型
            //Console.WriteLine("请输入第一个数字：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字：");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            ////通过if嵌套，对数字大小判断。
            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("第一个数字最大数字是：{0}",num1);
            //    if (num2 > num3)
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num3);
            //    }
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine("第一个数字最大数字是：{0}", num2);
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num3);
            //    }
            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine("第一个数字最大数字是：{0}", num3);
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("第二个数字最大数字是：{0}", num2);
            //    }
            //}
            //Console.ReadKey();




            ////if案例7: 输入密码，第一次错误提示密码错误，第二次错误，提示密码提示词，密码锁定
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //if (password == "123456")
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误，请重新输入");
            //    password = Console.ReadLine();
            //    if (password == "123456")
            //    {
            //        Console.WriteLine("密码正确，登录成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误次数过多，请稍后再试");
            //    }
            //}
            //Console.ReadKey();



            ////if案例8：同时对用户名和密码进行判断，使用if  else if 来做
            //Console.WriteLine("请输入用户名：");
            //string username = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();
            //if (username == "admin" && password == "123456")
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else if (username == "admin" && password != "123456")
            //{
            //    Console.WriteLine("密码错误，请重新输入");

            //}
            //else if (username != "admin" && password == "123456")
            //{
            //    Console.WriteLine("用户名错误，请重新输入");
            //}
            //else
            //{
            //    Console.WriteLine("用户名和密码都错误，请重新输入");
            //}
            //Console.ReadKey();



            //if案例9： 网站观看年龄判断
            Console.WriteLine("请输入您的年龄：");
            bool b = true;
            int age=0 ;
            try
            {
                 age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("年龄输入错误,格式不正确");
                b = false;
            }
            if (b)
            {
                if (age >= 18)
                {
                    Console.WriteLine("欢迎光临");

                }
                else if (age < 10)
                {
                    Console.WriteLine("小朋友，这不是该来的地方");

                }
                else
                {
                    Console.WriteLine("你确定要观看：YES/NO");
                    string resule = Console.ReadLine();
                    if (resule == "YES")
                    {
                        Console.WriteLine("观看成功");
                    }
                    else
                    {
                        Console.WriteLine("观看失败");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
