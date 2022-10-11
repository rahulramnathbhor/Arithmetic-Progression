using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Progression
{
   

    class MainClass
    {

        public static void Main()

        {

            int n, a, d;

            Console.Write("Enter the number of terms in the A.P.");

            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first term and common difference of A.P.");

            a = Convert.ToInt32(Console.ReadLine());

            d = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {

                Console.Write("{0} ", a);

                a = a + d;

            }

            Console.WriteLine("");

        }

    }
}
