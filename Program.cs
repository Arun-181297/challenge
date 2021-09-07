using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of inputs");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the value");
                string s = Console.ReadLine();
                string[] sp = s.Split();

                string R = sp[0];
                string Y = sp[1];
                string G = sp[2];

                int a = con(R, Y, G);
                sum += a;
                double b = sum / i;
               
                Console.WriteLine(b);
                
            }
        }
        public static int con(string R,string Y,string G)
        {
            string s = R + Y + G;
            int c = Convert.ToInt32(s);
            return c;
        }
    }
}
