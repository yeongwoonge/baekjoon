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
            int a = int.Parse(Console.ReadLine());
            Stack<long> c = new Stack<long>(); 
            for (int i = 0; i < a; i++)
            {
                long k = long.Parse(Console.ReadLine());
                if(k == 0)
                {
                    c.Pop();
                }
                else
                {
                    c.Push(k);
                }

            }
            sb.Append(c.Sum());






                // ------------------------------------------
                // sb.Append(); [제출용]
           Console.WriteLine(sb);
        }
    }
}