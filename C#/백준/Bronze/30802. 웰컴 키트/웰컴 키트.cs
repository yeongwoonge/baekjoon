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
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int d = 0;
            int e = 0;
            int f = 0;
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] == 0) continue;
                else if (b[i] % c[0] == 0) d = d + b[i] / c[0];
                else d = d + 1 + b[i] / c[0];
            }
            e = a / c[1];
            f = a % c[1];
            sb.Append(d+"\n");
            sb.Append(e + " " + f);

            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}