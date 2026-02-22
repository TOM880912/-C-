using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举与int和str之间的转换
{
    //声明枚举QQ状态
    public enum QQState
    { 
    Online=2,   //定义枚举开始的值，
    Offline,
    Leave=10,   //再次定义枚举的值，枚举的值可以多次定义
    Busy,
    Qme
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转为int类型；
            //QQState state = QQState.Leave;

            ////枚举类型默认可和int类型相互转换，枚举类型和int类型兼容；

            //int num = (int)state;   //枚举类型转换成int类型,并且赋值给变量num；
            
            //Console.WriteLine(num);    //输出变量值；
            //Console.WriteLine((int)QQState.Online);
            //Console.WriteLine((int)QQState.Offline);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.Qme);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转换为枚举
            ////将int类型转换成枚举，当int的值不在枚举中时，会输出原有int的值，并且不会报错；
            //int n = 30;
            //QQState state = (QQState)n;   //int类型转换成枚举类型，并且赋值给变量state；
            //Console.WriteLine(state);     
            //Console.ReadKey();
            #endregion




            //所有的类型都可以转换为str类型；
            //int n1 = 10;
            //string s1 = n1.ToString();   //将int类型转换成str类型,并赋值给变量s1；
            //Console.WriteLine(s1);
            //Console.ReadKey();

            #region 将枚举转换为str类型
            //QQState state = QQState.Online;       
            //string s = state.ToString();  //将枚举转换成为字符串
            //Console.WriteLine(s);
            //Console.ReadKey();

            #endregion

            #region 将str类型转换成为枚举
            string s = "Online";





        }
    }
}
