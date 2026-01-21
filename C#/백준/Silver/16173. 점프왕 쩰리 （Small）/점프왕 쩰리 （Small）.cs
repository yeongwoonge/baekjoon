using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace baekjoon_solution
{
    internal class Program
    {
        public static string ans = "";
        public static bool haru = false;
        public static void jelly(int a, int x, int y, int[][] b)
        {
            if (x+1 > a || y+1 > a) return;
            if (b[x][y] == -1) { haru = true; return; }
            int c = b[x][y];
            if (c != 0) { jelly(a, x + c, y, b); jelly(a, x, y + c, b); }
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); // [출력용]
            int a = int.Parse(Console.ReadLine()); // [입력용 숫자 하나]
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // [입력용 숫자 여러개]
            //string[] a = Console.ReadLine().Split(); // [입력용 문자열]
            // ------------------------------------------
            int[][] b = new int[a][];
            for (int i = 0; i< a; i++)
            {
                b[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            jelly(a, 0, 0, b);
            if (haru) sb.Append("HaruHaru");
            else sb.Append("Hing");

            // ------------------------------------------
            // sb.Append(); [제출용]
            Console.WriteLine(sb);
        }
    }
}