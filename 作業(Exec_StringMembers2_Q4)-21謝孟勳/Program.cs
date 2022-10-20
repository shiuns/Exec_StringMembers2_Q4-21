using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業_Exec_StringMembers2_Q4__21謝孟勳
{
    //假設有表示日期的字串"1100225", 請將它轉成表示西元年的日
    //期"20210225"
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(110, 02, 25).AddYears(1911);
            Console.WriteLine(dateTime);
        }
    }
}
