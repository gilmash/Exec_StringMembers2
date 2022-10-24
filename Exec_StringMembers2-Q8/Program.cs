using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("請輸入您的電話號碼:");
            string phonesNumbers = Console.ReadLine();

            
            if (string.IsNullOrEmpty(phonesNumbers) || phonesNumbers.Length != 10)
            {
                Console.WriteLine("號碼格式不對");
                return;
            }
            string result = phonesNumbers.Substring(0, 4) + new string('*', 4) + phonesNumbers.Substring(7, 2);
            Console.WriteLine(result);
        }
    }
}
