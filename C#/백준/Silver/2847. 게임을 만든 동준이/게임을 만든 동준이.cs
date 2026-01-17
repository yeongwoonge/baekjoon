using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            List<int> b = new List<int> { };
            int c = 0;
            for (int i=0;i<a;i++) b.Add(int.Parse(Console.ReadLine()));
            for (int i = a-2;i>=0;i--)
            {
                while (b[i] >= b[i + 1])
                {
                    b[i]--;
                    c++;
                }
            }
            sb.Append(c);



            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}