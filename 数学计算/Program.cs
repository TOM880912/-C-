using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数学计算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   数据计算
            //int chinese = 100;
            //int math = 90;
            //int english = 80;
            //int tatal = chinese + math + english;
            //double average = (double)tatal / 3;
            //Console.WriteLine("平均分数是：{0}",average);
            //Console.WriteLine("总分是：{0}",tatal);
            //Console.ReadKey();

            ////圆形面积周长计算
            //Console.WriteLine("请输入圆的半径");
            //double r = double.Parse(Console.ReadLine());
            //double L = 2 * r * 3.1415;
            //double s = 3.1415 * r * r;
            //Console.WriteLine("圆形的周长是：{0}，圆形的面积是：{1}",L,s);
            //Console.ReadKey();

            ////购物计算
            //Console.WriteLine("张三在商店买衣服，一共需要花费多少钱？");
            //Console.WriteLine("请输入T恤的价格：");
            //int tparent = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入衬衫的价格：");
            //int coat = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入裤子的价格：");
            //int pants = int.Parse(Console.ReadLine());
            //int total = tparent + coat + pants;
            //double total1 = total * 0.88;
            //Console.WriteLine("总共需要花费{0}元。88折的价格是{1}",total,total1);
            //Console.ReadKey();

            int days = 59;
            int week = days / 7;
            int day = days % 7;
            Console.WriteLine("{0}天是{1}周零{2}天", days, week, day);
            Console.ReadKey();


            //通过秒数计算周，天，时分秒
            int seconds = 107653;
            int week1 = seconds / (60 * 60 * 24 * 7);
            int day1 = seconds % (60 * 60 * 24 * 7) / (60 * 60 * 24);
            int hour1 = seconds % (60 * 60 * 24) / (60 * 60);
            int minutel = (seconds % (60 * 60)) / 60;
            int second = seconds % 60;
            Console.WriteLine("{0}秒等于{1}周零{2}天零{3}小时零{4}分钟零{5}秒", seconds, week1, day1, hour1, minutel, second);
            Console.ReadKey();

            seconds = 107653;
            int day2 = seconds / (60 * 60 * 24);
            int secs = seconds % (60 * 60 * 24);
            int hour2 = secs / (60 * 60);
            secs = secs % 3600;
            int min = secs / 60;
            secs = secs % 60;
            Console.WriteLine("{0}秒等于{1}天零{2}小时零{3}分钟零{4}秒", seconds, day2, hour2, min, secs);

            Console.ReadKey();


            #endregion


            #region  数据类型转换：


            //double转int
            double num = 10.2656;
            int num2 = (int)num;
            Console.WriteLine("double转int：{0} -> {1}", num, num2);
            Console.ReadKey();

            int n1 = 10;
            int n2 = 3;
            double A = n1 / n2;
            double B = n1 * 1.0 / n2;   //n1转换成浮点数
            double C = (double)n1 / n2; //n1转换成浮点数
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("{0:0.00}", C);  //占位符输出，保留两位小数
            Console.ReadKey();
            #endregion


            #region  不兼容数据类型转换：
            //字符串转int或者double
            string str1 = "123";
            double num3 = Convert.ToDouble(str1);
            int num4 = Convert.ToInt32(str1);
            Console.WriteLine("字符串转int：{0} -> {1}", str1, num4);
            Console.WriteLine("字符串转double：{0} -> {1}", str1, num3);
            Console.ReadKey();


            //不兼容字符串转换案例1
            //输入成绩，进行计算
            Console.WriteLine("请输入姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入英语成绩：");
            int english = Convert.ToInt32(Console.ReadLine());
            int total = chinese + math + english;
            double average = (double)total / 3;
            Console.WriteLine("姓名：{0}，总分：{1}，平均分：{2:0.000}", name, total, average);
            Console.ReadKey();




            #endregion





        }
    }
}
