using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace baekjoon_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); // [출력용]
            //int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = a[0];
            int y = a[1];
            int d = a[2];
            double t = a[3];
            double distance = Math.Sqrt(x * x + y * y);
            double origin = distance;
            double result = 0;
            
            if (d <= t)
            {
                sb.Append(distance);
            }
            else
            {
                while(distance >= d)
                {
                    distance -= d;
                    result += t;
                }
                double ans = result + distance;
                if (result == 0)
                {
                    ans = Math.Min(ans, t + (d - distance));
                    ans = Math.Min(ans, 2 * t);
                }
                else{
                    ans = Math.Min(ans, result + t);
                }
                ans = Math.Min(ans, origin);
                sb.Append(ans);
            }
            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}