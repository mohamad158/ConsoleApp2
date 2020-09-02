using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.AppendLine(" 2nd Line");
            sb.Append(".");

            Console.WriteLine(sb.ToString());
        }
    }
}
