using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入英文名字:");
            string name= Console.ReadLine();
            name= name.ToLower();

            string account = "Allen";
            account= account.ToLower();

            if (name == account)
            {
                Console.WriteLine("相符");
            }
            else
            {
                Console.WriteLine("輸入錯誤");
            }
        }
    }
}
