using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCaculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit != true)
            {
                //基础值 1492 1905
                int balance = 1492;
                int code = 0x1905;
                Console.WriteLine("输入整数计算次数或者输入'q'退出程序：");
                string input = Console.ReadLine();
                if (input == "q")
                    return;
                int a = Int32.Parse(input);
                Console.WriteLine("计算次数：" + a + "次。(+" + a * 0.06 + "元)");
                //计算循环 每次金额+6 校验码-1
                for (int i = 0; i < a; i++)
                {
                    balance += 6;
                    code -= 0x1;
                }
                //转换为16进制输出
                Console.WriteLine("计算完成\n金额：" + balance.ToString("x4") + "(" + balance * 0.01 + "元)" + "\n校验码：" + code.ToString("x4"));
            }
        }
    }
}
