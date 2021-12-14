using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int x; int y; char c;
            //char[] symbol=new char[]{'+','-','*','/'};
            Console .Write ("请输入第一个数：");
            x=Convert .ToInt32(Console.ReadLine ());
            Console .Write ("请输入第二个数：");
            y=Convert .ToInt32(Console .ReadLine ());
            Console.Write("请输入运算符：");
            c = Convert.To(Console.ReadLine());
            if(c=='+')
            {
            add(x,y);
            }
            sub(x,y);
            mul(x,y);
            dvi(x,y);


            Console.ReadLine();
        }
    }
}
