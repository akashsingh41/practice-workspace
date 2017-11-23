using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            String expression = "231*+9-";
            Console.WriteLine("Value = "+Expression_Evaluator.Postfix_Evaluator(expression));
            Console.ReadKey();
        }
    }
}
