using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举02
{
    //声明枚举
    public enum sesons
    { 
    春,
    夏,
    秋,
    冬
    }


    public enum QQState
    { 
    online,
    offline,
    leave,
    busy,
    call
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            sesons s = sesons.冬;
            Console.WriteLine(s);

            QQState q = QQState.leave;
            Console.WriteLine(q);


        }
    }
}
