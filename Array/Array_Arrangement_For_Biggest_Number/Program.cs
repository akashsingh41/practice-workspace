using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Arrangement_For_Biggest_Number
{
    class CustomSort : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            string ab = a + b;
            string ba = b + a;
            return Convert.ToInt32(ab) > Convert.ToInt32(ba) ? 1 : 0;
        }
    }
    class Program
    {    
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            input.Add("1");
            input.Add("34");
            input.Add("3");
            input.Add("98");
            input.Add("9");
            input.Add("76");
            input.Add("45");
            input.Add("4");

            input.Sort(new CustomSort().Compare);

            foreach (string x in input)
            {
                Console.Write(x);
            }

            Console.Read();
        }
    }
}
