using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            int count = a;
            for(int i=0; i<a; i++)
            {
                if (b[i] == 1) count--;
                for (int j = 2; j < b[i]; j++) if (b[i] % j == 0) { count--; break; }
            }
            sb.Append(count);

            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}