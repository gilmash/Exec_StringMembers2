using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入英文名字:");
            string name = Console.ReadLine();
            
            string account = "Allen";

            if (name != account)
            {
                Console.WriteLine("不相符");
            }
            else
            {
                Console.WriteLine("相符");
            }
        }
    }
}
