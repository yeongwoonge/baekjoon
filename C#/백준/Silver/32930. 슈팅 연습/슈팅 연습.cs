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
            int[][] b = new int[(a[0] + a[1])][];
            double[] c = new double[(a[0] + a[1])];
            double count = 0;
            for(int i = 0; i < a[0]; i++)
            {
                b[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                c[i] = Math.Sqrt(Math.Pow(b[i][0], 2) + Math.Pow(b[i][1], 2));
            }
            (int x, int y) current = (0, 0);
            int e = 0;
            for(int i = 0; i < a[1]; i++)
            {
                b[i+a[0]] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < i + a[0]; j++)
                {
                    if (c[j] == -1) continue;
                    c[j] = Math.Pow(b[j][0]-current.x,2) + Math.Pow(b[j][1]-current.y,2);
                }
                e = Array.IndexOf(c, c.Max());
                count += c[e];
                c[e] = -1;
                current = (b[e][0], b[e][1]);
            }

            sb.Append(count);





            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}