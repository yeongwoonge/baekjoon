using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text; 
using System.Threading.Tasks;

namespace baekjoon_solution
{
    internal class Program
    {
        public static int[] king;
        public static int depth(int a)
        {
            if (a == 1) return 1;
            if (a == 2) return 2;
            else
            {
                return (king[a - 2] + king[a - 3])%10007;
            }
        }    

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); // [출력용]
            int c = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            king = new int[c];
            for(int i = 0; i < c; i++)
            {
                king[i] = depth(i+1);
            }
            sb.Append(king[c-1]);

            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}