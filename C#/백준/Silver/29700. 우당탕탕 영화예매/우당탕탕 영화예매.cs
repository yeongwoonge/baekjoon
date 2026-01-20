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
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            string[] b = new string[a[0]];
            int count = 0;
            for(int i = 0; i < a[0]; i++)
            {
                b[i] = Console.ReadLine();
                for(int j = 0; j <= a[1] - a[2]; j++)
                {
                    int sum = 0;
                    for(int k = j; k < j + a[2]; k++)
                    {
                        sum += int.Parse(b[i][k].ToString());
                    }
                    if (sum == 0)
                    {
                        count++;
                    }
                }
            }
            sb.Append(count);
            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}