using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // StringBuilder 쓰려면 이거 필수
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

            int a = int.Parse(Console.ReadLine());
            long b = 0;
            long c = 1;
            bool d = true;
            List<long> e = new List<long> {0,1};
            int f = 0;
            while (f<a)
            {
                
                if (d)
                {
                    b = b + c;
                    e.Add(b);
                    d = !d;
                    f++;
                }
                else
                {
                    c = b + c;
                    e.Add(c);
                    d = !d;
                    f++;
                }
            }
            sb.Append(e[f]);


                // ------------------------------------------
                // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}