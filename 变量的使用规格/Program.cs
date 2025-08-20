using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量的使用规格
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////字符串拼接，
            ////案例1：介绍叫卡卡西的人
            //string name = "卡卡西";
            //int age = 25;
            //string address = "火影村";
            //string email = "12345678@qq.com";
            //double money = 5685.23;
            ////字符串拼接
            //Console.WriteLine("我叫" + name + ",我是" + age + "岁，住在" + address + ",我的邮箱" + email + ",我的工资" + money);
            ////
            //Console.WriteLine("我叫");
            ////占位符
            //Console.WriteLine("我叫{0},我是{1}岁，住在{2},我的邮箱{3},我的工资{4}", name, age, address, email, money);
            //Console.ReadKey();

            //字符串拼接案例2：介绍王阵的人
            //string name1 = "王阵";
            //int age1 = 35;
            //string address1 = "秦岭脚下";
            //string email1 = "420587172@qq.com";
            //string str1 = "努力学习c#，打算转行，祝我成功";
            //Console.WriteLine("我叫{0}，我今年{1}岁，我住在{2}，我的邮箱是{4}，我正在{3}.", name1, age1, address1,str1,email1);
            //Console.ReadKey();

            /*案例3：交换变量*/
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("num1={0},num2={1}", num1, num2);
            //交换num1和num2的值
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("num1={0},num2={1}", num1, num2);
            Console.ReadKey();

            //交换变量，不使用第三方变量
            int num4 = 10;
            int num5 = 20;
            Console.WriteLine("num4={0},num5={1}",num4,num5);
             num4 = num4 + num5;
            num5 = num4 - num5;
            num4 = num4 - num5;
            Console.WriteLine("num4={0},num5={1}",num4,num5);
           
            Console.ReadKey();
   
            




        }
    }
}
