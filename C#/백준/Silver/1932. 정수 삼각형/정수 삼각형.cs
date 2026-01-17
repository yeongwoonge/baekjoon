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
            int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            int[][] b = new int[a][];
            
            for (int i = 0; i<a; i++)
            {
                b[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            for (int i = 1; i < a ; i++)
            {
                for(int j = 0; j < b[i].Length; j++)
                {
                    if (j == 0) { b[i][j] += b[i - 1][j]; continue; }
                    if (j == b[i].Length - 1) { b[i][j] += b[i - 1][j - 1]; continue; }
                    if (b[i - 1][j] < b[i - 1][j-1]) b[i][j] += b[i - 1][j-1];
                    else b[i][j] += b[i - 1][j];
                }


            }

            sb.Append(b[a-1].Max());



            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}