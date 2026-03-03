using System;
using System.Text; 

namespace baekjoon_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            // ------------------------------------------
            int a = int.Parse(Console.ReadLine());

            bool[] cc = new bool[a];
            bool[] dgs = new bool[2 * a]; 
            bool[] sgd = new bool[2 * a]; 
            int cnt = 0;

            void queen(int row)
            {
                if (row == a)
                {
                    cnt++;
                    return;
                }
                for (int col = 0; col < a; col++)
                {
                    int d1 = row - col;
                    int d2 = row + col;
                    if (cc[col] || dgs[d1+a] || sgd[d2]) continue;
                    cc[col] = dgs[d1+a] = sgd[d2] = true;
                    queen(row + 1);
                    cc[col] = dgs[d1+a] = sgd[d2] = false;
                }
            }
            queen(0);
            sb.Append(cnt);
            // ------------------------------------------
            Console.WriteLine(sb);
        }
    }
}