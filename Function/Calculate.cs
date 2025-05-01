using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Calculate
    {
        public static double Calculator(int a, int b, string op = "+")
        {
            if (op == "+") return a + b;
            if (op == "-") return a - b;
            if (op == "*") return a * b;
            if (op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return 0;
                }
                return (double)a / b;
            }


            return a + b;
        }
    }
}
