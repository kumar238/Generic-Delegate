using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
   public class Program   
    {
        static void Main(string[] args)
        {
            Action<int, int> del1 = (x, y) => { Console.WriteLine($"Addition is {x + y}"); };
            del1(10, 20);

            Func<string, string> del2 = (str) => { return ($"Mr.{str}"); };
            Console.WriteLine(del2("kumar"));

            Func<string, string, string> del3 = (str1, str2) => $"{ str1}{str2}";
            Console.WriteLine(del3("kumar", "darivada"));

            string[] names = { "hari", "rahu", "ravi", "sravani" };
            Predicate<string> del4 = (str) => { return str.Equals("ravi"); };

            string s = Array.Find(names, del4);
            if (s == null)
                Console.WriteLine("not found");
            else
                Console.WriteLine($"{s} found in the names collection");


        }
    }
}
