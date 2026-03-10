using System;
using System.Linq;
using System.Text;

namespace baekjoon_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(); 
            int a = int.Parse(Console.ReadLine()); 
            // ------------------------------------------
            string[] b = new string[a];
            for (int i = 0; i < a; i++)
            {
                b[i] = Console.ReadLine();
                int[] cnt = new int[26];
                int[] cccnt = new int[10];
                foreach (char c in b[i])
                {
                    int index = c - 'A';
                    cnt[index]++;
                }

                while (cnt[25] > 0)
                {
                    cnt[25]--;
                    cnt[4]--;
                    cnt[17]--;
                    cnt[14]--;
                    cccnt[0]++;
                }

                while (cnt[22] > 0)
                {
                    cnt[22]--;
                    cnt[19]--;
                    cnt[14]--;
                    cccnt[2]++;
                }

                while (cnt[20] > 0)
                {
                    cnt[20]--;
                    cnt[5]--;
                    cnt[14]--;
                    cnt[18]--;
                    cccnt[4]++;
                }

                while (cnt[23] > 0)
                {
                    cnt[23]--;
                    cnt[8]--;
                    cnt[18]--;
                    cccnt[6]++;
                }

                while (cnt[6] > 0)
                {
                    cnt[6]--;
                    cnt[8]--;
                    cnt[4]--;
                    cnt[7]--;
                    cnt[19]--;
                    cccnt[8]++;
                }

                while (cnt[7] > 0)
                {
                    cnt[7]--;
                    cnt[19]--;
                    cnt[17]--;
                    cnt[4]--;
                    cnt[4]--;
                    cccnt[3]++;
                }

                while (cnt[5] > 0)
                {
                    cnt[5]--;
                    cnt[8]--;
                    cnt[21]--;
                    cnt[4]--;
                    cccnt[5]++;
                }

                while (cnt[14] > 0)
                {
                    cnt[14]--;
                    cnt[13]--;
                    cnt[4]--;
                    cccnt[1]++;
                }


                while (cnt[8] > 0)
                {
                    cnt[8]--;
                    cnt[13]--;
                    cnt[13]--;
                    cnt[4]--;
                    cccnt[9]++;
                }

                while (cnt[21] > 0)
                {
                    cnt[21]--;
                    cnt[18]--;
                    cnt[4]--;
                    cnt[4]--;
                    cnt[13]--;
                    cccnt[7]++;
                }

                sb.Append("Case #" + (i+1) + ": ");
                for(int j = 0; j < cccnt.Count(); j++)
                {
                    while (cccnt[j] > 0)
                    {
                        sb.Append(j);
                        cccnt[j]--;
                    }
                }
                sb.AppendLine();
            }
            // ------------------------------------------
            Console.WriteLine(sb);
        }
    }
}