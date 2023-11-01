using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many points?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            float sum = 0, unit, unit1 = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("pls enter number{0};", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("pls enter unit{0};", i + 1);
                unit = Convert.ToInt32(Console.ReadLine());
                sum += unit * num[i];
                unit1 += unit;

            }
            float avg = sum / unit1;
            Console.WriteLine("average you is:{0}", avg);
            Console.ReadKey();
        }
    }
}
//سورنا کریمی
//تمرین3
