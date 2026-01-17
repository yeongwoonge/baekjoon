using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_solution
{
    internal class Program
    {
        public static long x = 0;
        public static long y = 0;
        static (long x, long y) find(string[] a, long size)
        {
            x = size; y = size;
            string target = a[1].ToString();
            for (int i = 0; i < int.Parse(a[0]); i++)
            {
                if (size == 1) break;
                if (target[i] == '2' || target[i] == '1') y = y - (size / 2);
                if (target[i] == '2' || target[i] == '3') x = x - (size / 2);
                size /= 2;
            }
            return (x, y);
        }
        static string nana((long x, long y) a, long size, long count)
        {
            string ans = "";
            for (int i = 0; i < count; i++)
            {
                if (a.x <= size / 2 && a.y <= size / 2)
                {
                    ans += "2";
                }
                if (a.x > size / 2 && a.y <= size / 2)
                {
                    ans += "1";
                    a.x = a.x - size / 2;
                }
                if (a.x > size / 2 && a.y > size / 2)
                {
                    ans += "4";
                    a.x = a.x - size / 2;
                    a.y = a.y - size / 2;
                }
                if (a.x <= size / 2 && a.y > size / 2)
                {
                    ans += "3";
                    a.y = a.y - size / 2;
                }
                size /= 2;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); // [출력용]
            //int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            //long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse); // [입력용 숫자 여러개]
            string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int.Parse(a[0]);
            long size = 1L << int.Parse(a[0]);
            long border = size;
            (long x, long y) target = find(a, size);
            target.x += b[0];
            target.y -= b[1];
            if (target.x <= 0 || target.y <= 0 || target.x > border || target.y > border)
            {
                sb.Append(-1);
            }
            else
            {
                sb.Append(nana(target, size, int.Parse(a[0])));
            }
            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}