using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -12;
            int b = 0; //кол-во чисел
            int result = 0;
            for (int i = a; i <= -65; i++)
            {
                a = a + i;
                b++;
            }
            result = a / b;
            Console.WriteLine(result);
        }
    }
}
